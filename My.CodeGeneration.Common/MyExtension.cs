using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    public static class MyExtension
    {

        public static bool IsInt(this string str)
        {
            int test;
            return int.TryParse(str, out test);
        }
        public static bool IsInt(this string str, out int test)
        {
            return int.TryParse(str, out test);
        }

        public static bool IsLong(this string str)
        {
            long test;
            return long.TryParse(str, out test);
        }
        public static bool IsLong(this string str, out long test)
        {
            return long.TryParse(str, out test);
        }

        public static bool IsDateTime(this string str)
        {
            DateTime test;
            return DateTime.TryParse(str, out test);
        }
        public static bool IsDateTime(this string str, out DateTime test)
        {
            return DateTime.TryParse(str, out test);
        }

        public static int ToInt(this string str)
        {
            int test;
            int.TryParse(str, out test);
            return test;
        }
        public static long ToLong(this string str)
        {
            long test;
            long.TryParse(str, out test);
            return test;
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

        /// <summary>
        /// 打开一个文件，使用指定的编码读取文件的所有行，然后关闭该文件。
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string ReadAllText(this string path, Encoding encoding = null)
        {
            encoding = encoding ?? Encoding.UTF8;
            return System.IO.File.ReadAllText(path, encoding);//Encoding.GetEncoding("GBK")
        }
        /// <summary>
        /// 创建一个新文件，在其中写入指定的字符串，然后关闭文件。 如果目标文件已存在，则覆盖该文件。
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        public static void WriteAllText(this string path, string content)
        {
            System.IO.File.WriteAllText(path, content, Encoding.UTF8);
        }
        /// <summary>
        /// ToJson
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T ToObject<T>(this string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }
        /// <summary>
        /// ToJson
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this object obj)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }


    }
}
