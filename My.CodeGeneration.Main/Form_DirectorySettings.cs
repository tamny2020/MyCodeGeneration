using My.CodeGeneration.Common;
using My.CodeGeneration.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My.CodeGeneration.Main
{
    public partial class Form_DirectorySettings : Form_Base
    {
        private AppConfig config = null;
        public Form_DirectorySettings()
        {
            InitializeComponent();
            config = AppGlobalConfig.Intance.Config;
            this.textBox_SaveDir.Text = config.FileSaveDirectory;

            var list = CommonHelper.GetResourcesDirectories();
            comboBox_List.ValueMember = "Name";
            comboBox_List.DisplayMember = "Name";
            comboBox_List.DataSource = list;
            comboBox_List.Text = config.TempateDirectory;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (comboBox_List.SelectedValue != null)
            {
                config.TempateDirectory = comboBox_List.SelectedValue.ToString();
            }
            config.FileSaveDirectory = this.textBox_SaveDir.Text.Trim();
            AppGlobalConfig.Intance.Save(config);
            button_Close_Click(null, null);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Browse_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            this.textBox_SaveDir.Text = folderBrowserDialog.SelectedPath;
        }
    }


}
