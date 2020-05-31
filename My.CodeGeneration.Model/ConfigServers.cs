using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Model
{
    /// <summary>
    /// 配置服务器
    /// </summary>
    public class ConfigServers
    {
        /// <summary>
        /// 唯一标识
        /// </summary>
        public string Id { set; get; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 数据库类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 服务器
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// 数据库
        /// </summary>
        public string Database { get; set; }
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
        public string Port { get; set; }
        /// <summary>
        /// 数据库文件
        /// </summary>
        public string File { get; set; }

    }
}
