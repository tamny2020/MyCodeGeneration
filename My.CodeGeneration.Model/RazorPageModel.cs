using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Model
{
    public class RazorPageModel
    {
        /// <summary>
        /// 表名
        /// </summary>
        public string TableName { set; get; }

        /// <summary>
        /// 字段
        /// </summary>
        public List<Fields> Fields { set; get; }
    }
}
