using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Model
{
    /// <summary>
    /// 应用配置
    /// </summary>
    public class AppConfig
    {

        /// <summary>
        /// 默认模板目录
        /// </summary>
        public string TempateDirectory { set; get; }
        /// <summary>
        /// 文件保存目录
        /// </summary>
        public string FileSaveDirectory { set; get; }
    }
}
