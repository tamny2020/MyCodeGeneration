using My.CodeGeneration.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My.CodeGeneration.Common;

namespace My.CodeGeneration.MySql
{
    /// <summary>
    /// MySqlDatabase
    /// </summary>
    public class MySqlDatabase : IDatabase
    {

        public bool TestDatabaseConnnection(string serverId, out string errMessage)
        {
            MySqlConnection conn = new MySqlConnection(ServersHelper.GetConnectionString(serverId));
            try
            {
                conn.Open();
                errMessage = string.Empty;
                return true;
            }
            catch (MySqlException err)
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


            using (MySqlConnection conn = new MySqlConnection(ServersHelper.GetConnectionString(serverId)))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand("show databases", conn))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
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
            using (MySqlConnection conn = new MySqlConnection(ServersHelper.GetConnectionString(serverId, dbName)))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(string.Format("show full tables from {0} where table_type!='VIEW'", dbName), conn))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
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
            List<Model.Fields> fieldsList = new List<Model.Fields>();
            using (MySqlConnection conn = new MySqlConnection(ServersHelper.GetConnectionString(serverId, dbName)))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(string.Format("show full fields from {0}", tableName), conn))
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fieldsList.Add(new Model.Fields()
                        {
                            Name = dr[0].ToString(),
                            Type = GetFieldType(dr[1].ToString()),
                            Length = GetFieldLength(dr[1].ToString()),
                            IsNull = "YES" == dr[3].ToString().ToUpper(),
                            IsPrimaryKey = "PRI" == dr[4].ToString().ToUpper(),
                            Default = dr[5].ToString(),
                            IsIdentity = "auto_increment" == dr[6].ToString().ToLower(),
                            NetType = GetFieldType(GetFieldType(dr[1].ToString()), "YES" == dr[3].ToString().ToUpper()),
                            SqlType = GetFieldSqlType(GetFieldType(dr[1].ToString())),
                            Note = dr[8].ToString()
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
        /// 获取字段类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private string GetFieldType(string type)
        {
            if (!type.Contains('('))
            {
                return type;
            }
            return type.Substring(0, type.IndexOf('('));
        }
        /// <summary>
        /// 获取字段长度
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private int GetFieldLength(string type)
        {
            if (!type.Contains('('))
            {
                return -1;
            }
            string len = type.Substring(type.IndexOf('(') + 1).Replace(")", "");
            return len.IsInt() ? len.ToInt() : -1;
        }
        /// <summary>
        /// 获取字段的常规类型
        /// </summary>
        /// <param name="tName"></param>
        /// <param name="isNull"></param>
        /// <returns></returns>
        private string GetFieldType(string typeName, bool isNull)
        {
            switch (typeName.Trim().ToLower())
            {
                case "varchar":
                case "mediumtext":
                case "text":
                case "longtext":
                case "char":
                case "tinytext":
                    return "string";
                case "bit":
                    return isNull ? "bool?" : "bool";
                case "bigint":
                case "mediumint":
                    return isNull ? "long?" : "long";
                case "year":
                case "int":
                case "integer":
                    return isNull ? "int?" : "int";
                case "tinyint":
                    return isNull ? "sbyte?" : "sbyte";
                case "smallint":
                    return isNull ? "short?" : "short";
                case "decimal":
                    return isNull ? "decimal?" : "decimal";
                case "float":
                    return isNull ? "float?" : "float";
                case "double":
                    return isNull ? "double?" : "double";
                case "date":
                case "datetime":
                case "timestamp":
                case "time":
                    return isNull ? "DateTime?" : "DateTime";
                default: return "";
            }
        }

        /// <summary>
        /// 获取字段的MySqlDbType字符串
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        private string GetFieldSqlType(string typeName)
        {
            string r = string.Empty;
            switch (typeName)
            {
                case "varchar":
                    r = "MySqlDbType.VarChar";
                    break;
                case "text":
                    r = "MySqlDbType.Text";
                    break;
                case "longtext":
                    r = "MySqlDbType.LongText";
                    break;
                case "char":
                    r = "MySqlDbType.Char";
                    break;
                case "bigint":
                    r = "MySqlDbType.Int64";
                    break;
                case "bit":
                    r = "MySqlDbType.Bit";
                    break;
                case "int":
                    r = "MySqlDbType.Int32";
                    break;
                case "tinyint":
                    r = "MySqlDbType.Int16";
                    break;
                case "smallint":
                    r = "MySqlDbType.Int16";
                    break;
                case "decimal":
                    r = "MySqlDbType.Decimal";
                    break;
                case "float":
                    r = "MySqlDbType.Float";
                    break;
                case "double":
                    r = "MySqlDbType.Double";
                    break;
                case "datetime":
                    r = "MySqlDbType.DateTime";
                    break;
                case "smalldatetime":
                    r = "MySqlDbType.SmallDateTime";
                    break;
                case "date":
                    r = "MySqlDbType.Date";
                    break;
                case "time":
                    r = "MySqlDbType.Time";
                    break;
                case "year":
                    r = "MySqlDbType.Year";
                    break;
                case "timestamp":
                    r = "MySqlDbType.Timestamp";
                    break;
            }
            return r;
        }
        #endregion

    }
}
