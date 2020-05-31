using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Model.Enum
{
    /// <summary>
    /// 树节点类型
    /// </summary>
    public enum TreeNodeType
    {
        /// <summary>
        /// 服务器
        /// </summary>
        ServerNode,
        /// <summary>
        /// 数据库
        /// </summary>
        DataBaseNode,
        /// <summary>
        /// 表节点
        /// </summary>
        TableNode,
        /// <summary>
        /// 视图节点
        /// </summary>
        ViewNode,
        /// <summary>
        /// 表
        /// </summary>
        Table,
        /// <summary>
        /// 视图
        /// </summary>
        View,
        /// <summary>
        /// 字段
        /// </summary>
        Field
    }
}
