using My.CodeGeneration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    public class ConfigServersHelper
    {
       
        /// <summary>
        /// 文件路径
        /// </summary>
        static string JsonFile = string.Format(@"{0}Config\Servers.xml", AppDomain.CurrentDomain.BaseDirectory);
        static ConfigServersHelper()
        {

        }

       

        public static List<ConfigServers> GetAll()
        {
            var list = new List<ConfigServers>();
            var model = new ConfigServers
            {
                Database = "",
                Name = "172.18.30.6(MySql)",
                Port = "3306",
                Uid = "root",
                Pwd = "root",
                ServerName = "172.18.30.6",
                Type = "MySql",
                File = ""
            };
            list.Add(model);
            return list;
        }

        public static void Add(ConfigServers model)
        {

        }

        public static void Delete()
        {

        }

    }
}
