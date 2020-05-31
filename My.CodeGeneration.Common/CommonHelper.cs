using My.CodeGeneration.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    public class CommonHelper
    {

        public static string BaseDirectory = System.AppDomain.CurrentDomain.BaseDirectory;

        public static string NewGuid = Guid.NewGuid().ToString().Replace("-", "");

        public static string Resources = Path.Combine(BaseDirectory, "Resources");

        /// <summary>
        /// 获取资源目录下所有目录
        /// </summary>
        /// <returns></returns>
        public static List<TemplateDirec> GetResourcesDirectories()
        {
            var list = new List<TemplateDirec>();
            string[] dirs = Directory.GetDirectories(Resources, "*", SearchOption.AllDirectories);
            foreach (var item in dirs)
            {
                list.Add(new TemplateDirec
                {
                    Path = item,
                    Name = item.Substring(item.LastIndexOf('\\') + 1)
                });
            }
            return list;
        }
        /// <summary>
        /// 获取资源目录下所有文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }
        /// <summary>
        /// 获取代码类型名
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetCodeTypeName(string type)
        {
            string codeTypeName = "";
            switch (type)
            {
                case "cs": codeTypeName = ConstValue.CSharp; break;
                case "html": codeTypeName = ConstValue.HTML; break;
                case "php": codeTypeName = ConstValue.PHP; break;
                case "js": codeTypeName = ConstValue.JavaScript; break;
                case "java": codeTypeName = ConstValue.JAVA; break;
                default:
                    break;
            }
            return codeTypeName;
        }

        /// <summary>
        /// 解析类属性
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static List<ClassPropertity> ParseClassPropertityList(string str)
        {
            var list = new List<ClassPropertity>();
            if (string.IsNullOrWhiteSpace(str))
            {
                return list;
            }

            try
            {
                str = str.Substring(str.IndexOf("public class") + 12);
                //匹配字段
                string pattern = @"public [\s\S]*? { get; set; }";
                MatchCollection mc = Regex.Matches(str, pattern, RegexOptions.IgnoreCase);
                foreach (Match item in mc)
                {
                    var arr = item.Value.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    list.Add(new ClassPropertity { Type = arr[1], Name = arr[2] });
                }

                //匹配描述
                string pattern1 = @"<summary>[\s\S]*?</summary>";
                MatchCollection mc1 = Regex.Matches(str, pattern1, RegexOptions.IgnoreCase);
                int i = 0;
                foreach (Match item in mc1)
                {
                    var arr = item.Value.Replace("\r\n", "").Replace(" ", "").Split(new string[] { "///" }, StringSplitOptions.RemoveEmptyEntries);
                    if (arr.Length > 0)
                    {
                        list[i].Desc = arr[1];
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            return list;
        }
    }
}
