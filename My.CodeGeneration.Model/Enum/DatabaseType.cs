using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Model.Enum
{
    /// <summary>
    /// 数据库类型
    /// </summary>
    public enum DatabaseType
    {
        /// <summary>
        /// 未设置
        /// </summary>
        None,
        SqlServer,
        Access,
        MySql,
        Sqlite,
        Oracle
    }
}
