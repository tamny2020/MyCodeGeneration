using My.CodeGeneration.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XPTable.Models;

namespace My.CodeGeneration.Main
{
    public partial class Form_BuilderSelect : Form
    {
        public Action<Form_BuilderSelect, string[]> delegeAction = null;
        public Form_BuilderSelect(Action<Form_BuilderSelect, string[]> delegeAction)
        {
            InitializeComponent();
            this.delegeAction = delegeAction;

            var files = CommonHelper.GetFiles(CommonHelper.Resources + @"\" + AppGlobalConfig.Intance.Config.TempateDirectory);
            for (int i = 0; i < files.Length; i++)
            {
                var item = new ListViewItem { };
                item.Tag = files[i];
                item.Text = "";
                item.SubItems.Add(Path.GetFileName(files[i]));
                tableList.Items.Add(item);
            }

        }

        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            this.btnCreateCode.Text = "生成中...";
            var list = tableList.CheckedItems;
            var count = list.Count;
            if (count > 0)
            {
                string[] arr = new string[count];
                for (int i = 0; i < count; i++)
                {
                    arr[i] = list[i].Tag.ToString();
                }
                delegeAction(this, arr);
            }
            this.btnCreateCode.Text = "生成完成";
        }
    }
}
