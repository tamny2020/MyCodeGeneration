using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    /// <summary>
    /// 单例
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T> where T : class
    {
        private static T _instance;
        private static readonly object _objLock = new object();
        public static T GetInstance()
        {
            if (_instance == null)
            {
                lock (_objLock)
                {
                    if (_instance == null)
                    {
                        _instance = (T)Activator.CreateInstance(typeof(T), true);
                    }
                }
            }
            return _instance;
        }

        public static void SetInstance(T value)
        {
            lock (_objLock)
            {
                _instance = value;
            }
        }
    }
}
