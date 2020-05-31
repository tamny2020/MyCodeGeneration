using My.CodeGeneration.Common;
using My.CodeGeneration.Model;
using My.CodeGeneration.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Business
{
    /// <summary>
    /// 
    /// </summary>
    public class Factory : ObjectFactoryHelper
    {
        public static IDatabase CreateDatabaseInstance(DatabaseType databaseType)
        {

            string dllName = string.Empty;
            if (databaseType == DatabaseType.SqlServer2000
                || databaseType == DatabaseType.SqlServer2005
                || databaseType == DatabaseType.SqlServer2008)
            {
                dllName = "SqlServer";
            }
            else
            {
                dllName = databaseType.ToString();
            }
            return (IDatabase)CreateInstance("My.CodeGeneration." + dllName, dllName + "Database");
        }
    }
}
