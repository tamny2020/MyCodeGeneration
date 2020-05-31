using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Model
{
    public interface IDatabase
    {
        /// <summary>
        /// 测试数据库连接
        /// </summary>
        /// <param name="connectionString">连接字符串</param>
        /// <param name="errMessage">错误信息</param>
        /// <returns></returns>
        bool TestDatabaseConnnection(string serverId, out string errMessage);
        /// <summary>
        /// 获取服务器所有数据库
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        List<string> GetDatabaseList(string serverId);
        /// <summary>
        /// 获取数据库所有表
        /// </summary>
        /// <param name="serverId"></param>
        /// <returns></returns>
        List<Tables> GetTables(string serverId, string dbName);
        /// <summary>
        /// 获取表中所有字段
        /// </summary>
        /// <param name="serverId"></param>
        /// <param name="dbName"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        List<Fields> GetFields(string serverId, string dbName, string tableName);

    }
}
