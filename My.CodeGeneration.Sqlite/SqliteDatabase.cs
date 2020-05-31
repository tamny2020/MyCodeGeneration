using My.CodeGeneration.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Sqlite
{
    /// <summary>
    /// SqliteDatabase
    /// </summary>
    public class SqliteDatabase : IDatabase
    {
        public bool TestDatabaseConnnection(string serverId, out string errMessage)
        {
            SQLiteConnection conn = new SQLiteConnection("");
            try
            {
                conn.Open();
                errMessage = string.Empty;
                return true;
            }
            catch (SQLiteException err)
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
            Servers server = null;
            List<string> dbList = new List<string>();
            if (server == null)
            {
                return dbList;
            }
            else
            {
                dbList.Add(System.IO.Path.GetFileName(server.Server));
            }
            return dbList;
        }

        public List<Tables> GetTables(string serverId, string dbName)
        {
            List<Model.Tables> tblList = new List<Model.Tables>();
            using (SQLiteConnection conn = new SQLiteConnection(""))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("select tbl_name from sqlite_master where type='table' order by name", conn))
                {
                    SQLiteDataReader dr = cmd.ExecuteReader();
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
            List<Fields> fieldsList = new List<Fields>();
            using (SQLiteConnection conn = new SQLiteConnection(""))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(string.Format("PRAGMA table_info({0})", tableName), conn))
                {
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        fieldsList.Add(new Model.Fields()
                        {
                            Name = dr["name"].ToString(),
                            Type = dr["type"].ToString(),
                            IsNull = "1" != dr["notnull"].ToString(),
                            IsPrimaryKey = "1" == dr["pk"].ToString(),
                            Default = dr["dflt_value"].ToString(),
                            IsIdentity = "1" == dr["pk"].ToString() && "INTEGER" == dr["type"].ToString(),
                            NetType = GetFieldType(dr["type"].ToString(), "1" != dr["notnull"].ToString()),
                            SqlType = GetFieldSqlType(dr["type"].ToString()),
                            Note = "",
                            Length = -1
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
        /// 获取字段的常规类型
        /// </summary>
        /// <param name="tName"></param>
        /// <param name="isNull"></param>
        /// <returns></returns>
        private string GetFieldType(string typeName, bool isNull)
        {
            string r = string.Empty;
            if (typeName.IndexOf('(') > 0)
            {
                typeName = typeName.Substring(0, typeName.IndexOf('('));
            }
            switch (typeName.Trim().ToLower())
            {
                case "varchar":
                case "text":
                    r = "string";
                    break;
                case "char":
                    r = "char";
                    break;
                case "boolean":
                    r = isNull ? "bool?" : "bool";
                    break;
                case "integer":
                case "numeric":
                    r = isNull ? "long?" : "long";
                    break;
                case "int":
                    r = isNull ? "int?" : "int";
                    break;
                case "real":
                    r = isNull ? "decimal?" : "decimal";
                    break;
                case "date":
                case "datetime":
                    r = isNull ? "DateTime?" : "DateTime";
                    break;
            }
            return r;
        }
        /// <summary>
        /// 获取字段的SQLiteDbType字符串
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        private string GetFieldSqlType(string typeName)
        {
            if (typeName.IndexOf('(') > 0)
            {
                typeName = typeName.Substring(0, typeName.IndexOf('('));
            }
            string r = string.Empty;
            switch (typeName.Trim().ToLower())
            {
                case "varchar":
                    r = "DbType.AnsiString";
                    break;

                case "text":
                    r = "DbType.String";
                    break;

                case "char":
                    r = "DbType.String";
                    break;

                case "integer":
                case "numeric":
                    r = "DbType.Int64";
                    break;

                case "int":
                    r = "DbType.Int32";
                    break;

                case "real":
                    r = "DbType.Decimal";
                    break;
                case "date":
                case "datetime":
                    r = "DbType.DateTime";
                    break;

            }
            return r;
        } 
        #endregion

    }
}
