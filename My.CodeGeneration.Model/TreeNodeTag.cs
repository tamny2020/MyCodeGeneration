using My.CodeGeneration.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Model
{
    /// <summary>
    /// 树节点标签
    /// </summary>
    public class TreeNodeTag
    {
        /// <summary>
        /// 节点类型
        /// </summary>
        public TreeNodeType Type { get; set; }
        /// <summary>
        /// 节点参数
        /// </summary>
        public object Tag { get; set; }
    }
}
