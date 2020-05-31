using RazorEngine.Templating;
using RazorEngine.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    public class CustomRazorTemplate<T> : TemplateBase<T>
    {
        public string MyUpper(string name)
        {
            return name.ToUpper();
        }

        /// <summary>
        /// 获取数据表名前缀
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="isToUpper">是否大写</param>
        /// <returns></returns>
        public string GetTablePrefix(string tableName, bool isToUpper = true)
        {
            var arr = tableName.Split('_');
            return arr.Length == 0 ? "" : isToUpper ? arr[0].ToUpper() : arr[0];
        }
        /// <summary>
        /// 获取表名
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="capitalize">首字母大写</param>
        /// <returns></returns>
        public string GetTableName(string tableName, bool capitalize = true)
        {
            if (string.IsNullOrWhiteSpace(tableName)) return "";
            var arr = tableName.Split('_');
            if (arr.Length == 0) return "";
            return Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(arr.Last());
        }
        /// <summary>
        /// 用于输出原始html
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public IEncodedString RawHtml(string content)
        {
            return new RawString(content);
        }

        /// <summary>
        /// 用于输出转义后字符
        /// </summary>
        /// <param name="value">参数</param>
        /// <returns></returns>
        public static HtmlEncodedString RawText(string content)
        {
            return new HtmlEncodedString(content);
        }

    }
}
