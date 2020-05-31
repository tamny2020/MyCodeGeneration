using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    /// <summary>
    /// Json转化类
    /// </summary>
    public class JsonTransformClass
    {
        private StringBuilder builder = new StringBuilder();
        private Dictionary<string, List<string>> classDict = new Dictionary<string, List<string>>();
        public JsonTransformClass(string className, string json)
        {
            classDict.Add(className, new List<string>());
            var dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
            foreach (var item in dic)
            {
                JsonValueParse(className, item.Key, item.Value.ToString());
            }
        }
        /// <summary>
        /// 创建实体类
        /// </summary>
        /// <returns></returns>
        public string BuilderClass()
        {
            foreach (var item in classDict)
            {
                builder.AppendLine("public class " + item.Key + "");
                builder.AppendLine("{ ");

                item.Value.ForEach(x =>
                {
                    builder.AppendLine("     public string " + x + " {set;get;}");
                });

                builder.AppendLine("}");
            }
            return builder.ToString();
        }
        /// <summary>
        /// Json值解析
        /// </summary>
        /// <param name="className"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void JsonValueParse(string className, string name, object value)
        {
            if (value.ToString().IndexOf('{') == 0)
            {
                if (!classDict.ContainsKey(name))
                {
                    classDict.Add(name, new List<string>());
                }
                var dic = JsonConvert.DeserializeObject<Dictionary<string, object>>(value.ToString());
                foreach (var item in dic)
                {
                    JsonValueParse(name, item.Key, item.Value);
                }
                //classDict[className].Exists();
                //Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name);
            }
            else
            {
                classDict[className].Add(name);
            }
        }
    }
}
