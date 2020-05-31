using My.CodeGeneration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My.CodeGeneration.Common;
using System.Data.SqlClient;
using System.Data;
using My.CodeGeneration.Model.Enum;

namespace My.CodeGeneration.SqlServer
{
    /// <summary>
    /// SqlServerDatabase
    /// </summary>
    public class SqlServerDatabase : IDatabase
    {
        public bool TestDatabaseConnnection(string serverId, out string errMessage)
        {
            SqlConnection conn = new SqlConnection(ServersHelper.GetConnectionString(serverId));
            try
            {
                conn.Open();
                errMessage = string.Empty;
                return true;
            }
            catch (SqlException err)
            {
                errMessage = err.Message;
                return false;
            }
            finally
            {
                conn.Dispose();
            }
        }

        public List<string> GetDatabaseList(string serverId)
        {
            List<string> dbList = new List<string>();
            using (SqlConnection conn = new SqlConnection(ServersHelper.GetConnectionString(serverId)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select name from sysdatabases", conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        dbList.Add(dr.GetString(0));
                    }
                    dr.Close();
                    dr.Dispose();
                }
            }
            return dbList;
        }

        public List<Tables> GetTables(string serverId, string dbName)
        {
            List<Model.Tables> tblList = new List<Model.Tables>();
            using (SqlConnection conn = new SqlConnection(ServersHelper.GetConnectionString(serverId, dbName)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT name FROM sysobjects WHERE xtype='u' order by name", conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        tblList.Add(new Model.Tables() { Name = dr.GetString(0) });
                    }
                    dr.Close();
                    dr.Dispose();
                }
            }
            return tblList;
        }

        public List<Fields> GetFields(string serverId, string dbName, string tableName)
        {
            List<Fields> fieldsList = new List<Model.Fields>();
            Servers server = ServersHelper.GetServers(serverId);
            if (server == null)
            {
                return fieldsList;
            }

            using (SqlConnection conn = new SqlConnection(ServersHelper.GetConnectionString(serverId, dbName)))
            {
                conn.Open();
                string sql = string.Format(@"select a.name as f_name,b.name as t_name,[length],a.isnullable as is_null from 
                        sys.syscolumns a inner join sys.types b on b.user_type_id=a.xtype where object_id('{0}')=id order by a.colid", tableName);
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fieldsList.Add(new Fields()
                        {
                            Name = dr.GetString(0),
                            Type = dr.GetString(1),
                            Length = GetFieldLength(dr.GetString(1), dr.GetInt16(2)),
                            IsNull = 1 == dr.GetInt32(3),
                            IsPrimaryKey = IsPrimaryKey(serverId, dbName, tableName, dr.GetString(0)),
                            IsIdentity = IsIdentity(serverId, dbName, tableName, dr.GetString(0)),
                            NetType = GetFieldType(dr.GetString(1), 1 == dr.GetInt32(3)),
                            SqlType = GetFieldSqlType(dr.GetString(1)),
                            Note = GetFieldNote(serverId, dbName, tableName, dr.GetString(0))
                        });
                    }
                    dr.Close();
                    dr.Dispose();
                }
            }
            return fieldsList;
        }

        #region 辅助方法
        /// <summary>
        /// 判断一个表的某列是否为主键
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        private bool IsPrimaryKey(string serverId, string dbName, string tableName, string fieldName)
        {
            using (SqlConnection conn = new SqlConnection(ServersHelper.GetConnectionString(serverId, dbName)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "sp_pkeys";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@table_name", tableName));
                    using (SqlDataAdapter dap = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        dap.Fill(dt);
                        return dt.Select("COLUMN_NAME='" + fieldName + "'").Length > 0;
                    }
                }
            }
        }
        /// <summary>
        /// 判断一个表的某列是否为自增列
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        private bool IsIdentity(string serverId, string dbName, string tableName, string fieldName)
        {
            using (SqlConnection conn = new SqlConnection(ServersHelper.GetConnectionString(serverId, dbName)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select COLUMNPROPERTY(object_id('" + tableName + "'),'" + fieldName + "','IsIdentity')";
                    return "1" == cmd.ExecuteScalar().ToString();
                }
            }
        }
        /// <summary>
        /// 取一个字段的备注说明
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <param name="fieldName"></param>
        /// <returns></returns>
        private string GetFieldNote(string serverId, string dbName, string tableName, string fieldName)
        {
            using (SqlConnection conn = new SqlConnection(ServersHelper.GetConnectionString(serverId, dbName)))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"select value from sys.extended_properties a 
                        left join sys.syscolumns b on a.major_id=b.id and a.minor_id=b.colid 
                        where a.name='MS_Description' and object_id('" + tableName + "')=a.major_id and b.name='" + fieldName + "'";
                    object obj = cmd.ExecuteScalar();
                    return obj == null ? string.Empty : obj.ToString();
                }
            }
        }
        /// <summary>
        /// 获取字段的常规类型
        /// </summary>
        /// <param name="tName"></param>
        /// <param name="isNull"></param>
        /// <returns></returns>
        private string GetFieldType(string typeName, bool isNull)
        {
            string r = string.Empty;
            switch (typeName.Trim().ToLower())
            {
                case "varchar":
                case "nvarchar":
                case "text":
                case "ntext":
                case "char":
                case "nchar":
                case "xml":
                    r = "string";
                    break;
                case "uniqueidentifier":
                    r = isNull ? "Guid?" : "Guid";
                    break;
                case "bit":
                    r = isNull ? "bool?" : "bool";
                    break;
                case "bigint":
                    r = isNull ? "long?" : "long";
                    break;
                case "int":
                    r = isNull ? "int?" : "int";
                    break;
                case "tinyint":
                    r = isNull ? "byte?" : "byte";
                    break;
                case "smallint":
                    r = isNull ? "short?" : "short";
                    break;
                case "smallmoney":
                case "decimal":
                case "numeric":
                case "money":
                    r = isNull ? "decimal?" : "decimal";
                    break;
                case "real":
                    r = isNull ? "float?" : "float";
                    break;
                case "float":
                    r = isNull ? "double?" : "double";
                    break;
                case "date":
                case "datetime":
                case "datetime2":
                case "smalldatetime":
                case "datetimeoffset":
                    r = isNull ? "DateTime?" : "DateTime";
                    break;
                case "image":
                    r = "byte[]";
                    break;
            }
            return r;
        }
        /// <summary>
        /// 获取字段的SqlDbType字符串
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        private string GetFieldSqlType(string typeName)
        {
            string r = string.Empty;
            switch (typeName.ToLower())
            {
                case "varchar":
                    r = "SqlDbType.VarChar";
                    break;
                case "nvarchar":
                    r = "SqlDbType.NVarChar";
                    break;
                case "text":
                    r = "SqlDbType.Text";
                    break;
                case "ntext":
                    r = "SqlDbType.NText";
                    break;
                case "char":
                    r = "SqlDbType.Char";
                    break;
                case "nchar":
                    r = "SqlDbType.VarChar";
                    break;
                case "uniqueidentifier":
                    r = "SqlDbType.UniqueIdentifier";
                    break;
                case "bigint":
                    r = "SqlDbType.BigInt";
                    break;
                case "bit":
                    r = "SqlDbType.Bit";
                    break;
                case "int":
                    r = "SqlDbType.Int";
                    break;
                case "tinyint":
                    r = "SqlDbType.TinyInt";
                    break;
                case "smallint":
                    r = "SqlDbType.SmallInt";
                    break;
                case "smallmoney":
                    r = "SqlDbType.SmallMoney";
                    break;
                case "numeric":
                case "decimal":
                    r = "SqlDbType.Decimal";
                    break;
                case "float":
                    r = "SqlDbType.Float";
                    break;
                case "money":
                    r = "SqlDbType.Money";
                    break;
                case "real":
                    r = "SqlDbType.Real";
                    break;
                case "datetime":
                    r = "SqlDbType.DateTime";
                    break;
                case "datetime2":
                    r = "SqlDbType.DateTime2";
                    break;
                case "smalldatetime":
                    r = "SqlDbType.SmallDateTime";
                    break;
                case "date":
                    r = "SqlDbType.Date";
                    break;
                case "datetimeoffset":
                    r = "SqlDbType.DateTimeOffset";
                    break;
                case "image":
                    r = "SqlDbType.Image";
                    break;
            }
            return r;
        }
        /// <summary>
        /// 获取字段的参数长度
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        private int GetFieldLength(string typeName, int length)
        {
            int r = -1;
            switch (typeName)
            {
                case "varchar":
                    r = length == -1 ? -1 : length;
                    break;
                case "nvarchar":
                    r = length == -1 ? -1 : length;
                    break;
                case "numeric":
                case "decimal":
                case "datetime":
                case "smalldatetime":
                    r = length;
                    break;
            }
            return r;
        }

        #endregion

    }
}
