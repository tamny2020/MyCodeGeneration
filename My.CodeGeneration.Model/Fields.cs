using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Model
{
    /// <summary>
    /// 字段
    /// </summary>
    public class Fields
    {
        /// <summary>
        /// 名称
        /// </summary> 
        public string Name { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 长度
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// 是否可为空
        /// </summary>
        public bool IsNull { get; set; }
        /// <summary>
        /// 是否是主键
        /// </summary>
        public bool IsPrimaryKey { get; set; }
        /// <summary>
        /// 是否是自增列
        /// </summary>
        public bool IsIdentity { get; set; }
        /// <summary>
        /// 对应的.net类型
        /// </summary>
        public string NetType { get; set; }
        /// <summary>
        /// 对应的.net SQL类型
        /// </summary>
        public string SqlType { get; set; }
        /// <summary>
        /// 默认值 
        /// </summary>
        public string Default { get; set; }
        /// <summary>
        /// 备注说明
        /// </summary>
        public string Note { get; set; }

    }
}
