using My.CodeGeneration.Common;
using My.CodeGeneration.Model;
using My.CodeGeneration.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Business
{
    /// <summary>
    /// BLL_Database
    /// </summary>
    public class BLL_Database
    {

        private DatabaseType databaseType = DatabaseType.None;
        private IDatabase instance;
        public BLL_Database(DatabaseType databaseType)
        {
            this.databaseType = databaseType;
            instance = ObjectFactory.CreateDatabaseInstance(databaseType);
        }
        /// <summary>
        /// 测试数据库连接
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="errMessage"></param>
        /// <returns></returns>
        public bool TestDatabaseConnnection(string serverId, out string errMessage)
        {
            return instance.TestDatabaseConnnection(serverId, out errMessage);
        }
        /// <summary>
        /// 得到所有数据库
        /// </summary>
        /// <param name="serverId"></param>
        /// <returns></returns>
        public List<string> GetDatabases(string serverId)
        {
            return instance.GetDatabaseList(serverId);
        }
        /// <summary>
        /// 得到数据库所有表
        /// </summary>
        /// <param name="serverId"></param>
        /// <returns></returns>
        public List<Tables> GetTables(string serverId, string dbName)
        {
            return instance.GetTables(serverId, dbName);
        }
        /// <summary>
        /// 得到一个表中所有字段
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<Fields> GetFields(string serverId, string dbName, string tableName)
        {
            return instance.GetFields(serverId, dbName, tableName);
        }
    }
}
