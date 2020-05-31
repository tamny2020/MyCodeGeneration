using My.CodeGeneration.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Model
{
    /// <summary>
    /// 服务器
    /// </summary>
    public class Servers
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        public DatabaseType Type { get; set; }
        /// <summary>
        /// 服务器
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// 数据库
        /// </summary>
        public string DatabaseName { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string Uid { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }
        /// <summary>
        /// 端口
        /// </summary>
        public int? Port { get; set; }

    }
}
