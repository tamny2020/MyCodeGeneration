using My.CodeGeneration.Model;
using My.CodeGeneration.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    /// <summary>
    /// 服务器帮助类
    /// </summary>
    public class ServersHelper
    {
        /// <summary>
        /// 服务器列表
        /// </summary>
        private static List<Servers> ServerList = new List<Servers>();
        private static Dictionary<DatabaseType, string> defaultDatabase = null;
        static ServersHelper()
        {
            defaultDatabase = DefaultDatabase();
        }
        /// <summary>
        /// 新增服务器
        /// </summary>
        /// <param name="ser"></param>
        public static void AddServers(Servers ser)
        {
            ServerList.Add(ser);
            var model = new ConfigServers
            {
                Id = ser.Id,
                Name = string.Format("{0}({1})", ser.Name, ser.Type.ToString()),
                Type = ser.Type.ToString(),
                Server = ser.Server,
                Uid = ser.Uid,
                Pwd = ser.Pwd
            };
            ServersConfigClass.Instance.Add(model);
        }
        /// <summary>
        /// 获取服务器
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Servers GetServers(string id)
        {
            return ServerList.FirstOrDefault(x => x.Id == id);
        }
        /// <summary>
        /// 系统默认库
        /// </summary>
        private static Dictionary<DatabaseType, string> DefaultDatabase()
        {
            Dictionary<DatabaseType, string> dict = new Dictionary<DatabaseType, string>();
            dict.Add(DatabaseType.Access, "");
            dict.Add(DatabaseType.None, "");
            dict.Add(DatabaseType.MySql, "mysql");
            dict.Add(DatabaseType.Oracle, "");
            dict.Add(DatabaseType.Sqlite, "");
            dict.Add(DatabaseType.SqlServer, "master");
            return dict;
        }
        /// <summary>
        /// 获取服务器默认库
        /// </summary>
        /// <param name="dbType"></param>
        /// <returns></returns>
        public static string GetServerDefaultDatabase(DatabaseType dbType)
        {
            var dict = defaultDatabase[dbType];
            return dict == null ? "" : dict;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="ser"></param>
        public static void Delete(Servers ser)
        {
            if (ServerList != null)
            {
                ServerList.Remove(ser);
            }

        }
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <param name="serverId"></param>
        /// <returns></returns>
        public static string GetConnectionString(string serverId, string dbName = "")
        {
            var server = GetServers(serverId);
            if (server == null)
            {
                return string.Empty;
            }

            string connString = string.Empty;
            switch (server.Type)
            {
                case DatabaseType.SqlServer:
                    connString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                        server.Server,
                        dbName.IsNullOrEmpty() ? server.DatabaseName.IsNullOrEmpty() ? GetServerDefaultDatabase(server.Type) : server.DatabaseName : dbName,
                        server.Uid,
                        server.Pwd);
                    break;
                case DatabaseType.MySql:
                    connString = string.Format("Server={0};{1};Database={2};Uid={3};Pwd={4};",
                        server.Server,
                        server.Port.HasValue && server.Port.Value != -1 ? "Port=" + server.Port.Value : "", dbName.IsNullOrEmpty() ? server.DatabaseName.IsNullOrEmpty() ? GetServerDefaultDatabase(server.Type) : server.DatabaseName : dbName,
                        server.Uid,
                        server.Pwd);
                    break;
                case DatabaseType.Sqlite:
                    connString = string.Format("Data Source={0};Pooling=true;FailIfMissing=false;{1}",
                        server.Server,
                        server.Pwd.IsNullOrEmpty() ? "" : string.Format("Password={0}",
                        server.Pwd));
                    break;
            }

            return connString;

        }

    }
}
