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

namespace My.CodeGeneration.Main
{
    public partial class Form_ExportWord : Form_Base
    {
        public Form_ExportWord()
        {
            InitializeComponent();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_SaveDir.Text))
            {
                ShowBox("请选择导出目录");
                return;
            }
            button_Export.Text = "导出中...";
            button_Export.Enabled = false;
            Form_Main.form_Database.ExportWord(Path.Combine(textBox_SaveDir.Text, DateTime.Now.ToString("yyMMddHHmmssfff") + ".docx"));
            this.Close();
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
