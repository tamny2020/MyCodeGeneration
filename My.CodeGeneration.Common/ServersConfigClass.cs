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
    /// 服务器配置类
    /// </summary>
    public class ServersConfigClass
    {
        /// <summary>
        /// 实例
        /// </summary>
        public static ServersConfigClass Instance = Singleton<ServersConfigClass>.GetInstance();
        /// <summary>
        /// 服务器集合
        /// </summary>
        private List<ConfigServers> list = new List<ConfigServers>();
        /// <summary>
        /// 文件路径
        /// </summary>
        private string jsonFile = string.Format(@"{0}Configs\Servers.json", CommonHelper.BaseDirectory);
        /// <summary>
        /// 构造函数
        /// </summary>
        public ServersConfigClass()
        {
            if (!File.Exists(jsonFile))
            {
                File.Create(jsonFile);
                return;
            }
            string json = jsonFile.ReadAllText();
            list = json.ToObject<List<ConfigServers>>();
        }
        /// <summary>
        /// 获取
        /// </summary>
        /// <returns></returns>
        public List<ConfigServers> GetList()
        {
            return list;
        }
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        public void Add(ConfigServers model)
        {
            if (!list.Exists(x => x.Name == model.Name))
            {
                list.Add(model);
                Save();
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        public void Delete(ConfigServers model)
        {
            list.Remove(model);
            Save();
        }
        /// <summary>
        /// 保存
        /// </summary>
        private void Save()
        {
            jsonFile.WriteAllText(list.ToJson());
        }

    }
}
