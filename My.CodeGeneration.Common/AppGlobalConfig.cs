using My.CodeGeneration.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    /// <summary>
    /// 应用全局配置
    /// </summary>
    public class AppGlobalConfig
    {
        private static string jsonFile = string.Format(@"{0}Configs\App.json", CommonHelper.BaseDirectory);
        public static AppGlobalConfig Intance = Singleton<AppGlobalConfig>.GetInstance();
        public AppConfig Config = new AppConfig();
        public AppGlobalConfig()
        {
            string json = jsonFile.ReadAllText();
            Config = json.ToObject<AppConfig>();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="model"></param>
        public void Save(AppConfig model)
        {
            Config = model;
            jsonFile.WriteAllText(model.ToJson());
        }
    }
}
