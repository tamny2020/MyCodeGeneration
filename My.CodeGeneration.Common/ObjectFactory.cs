using My.CodeGeneration.Model;
using My.CodeGeneration.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    /// <summary>
    /// 工厂帮助类
    /// </summary>
    public class ObjectFactory
    {
        public static IDatabase CreateDatabaseInstance(DatabaseType databaseType)
        {

            string dllName = string.Empty;
            if (databaseType == DatabaseType.SqlServer)
            {
                dllName = "SqlServer";
            }
            else
            {
                dllName = databaseType.ToString();
            }
            return (IDatabase)CreateInstance("My.CodeGeneration." + dllName, dllName + "Database");
        }
        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="assemblyString"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        public static object CreateInstance(string assemblyString, string className)
        {
            //My.CodeGeneration.MySql.MySqlDatabase
            //My.CodeGeneration.MySqlDatabase

            object obj = Assembly.Load(assemblyString).CreateInstance(string.Format("{0}.{1}", assemblyString, className));
            if (obj == null)
            {

            }
            return obj;
        }
    }
}
