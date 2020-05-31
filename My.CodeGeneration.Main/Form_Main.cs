using My.CodeGeneration.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace My.CodeGeneration.Main
{
    public partial class Form_Main : DockContent
    {
        public static Form_Main Instance = null;
        public static Form_Home form_Home = null;
        public static Form_Database form_Database = null;
        public Form_Main()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Index_Load(object sender, EventArgs e)
        {
            form_Database = new Form_Database();
            form_Database.AddDockPannel(dockPanel, DockState.DockLeft);

            form_Home = new Form_Home();
            form_Home.AddDockPannel(dockPanel);
            form_Home.Activate();
        }

        private void toolStripMenuItemDelServers_Click(object sender, EventArgs e)
        {
            form_Database.RemoveServers();
        }

        private void toolStripMenuItemAddServers_Click(object sender, EventArgs e)
        {
            new Form_AddServer().ShowDialog();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem_ClassConvert_Click(object sender, EventArgs e)
        {
            new Form_ClassConvert().AddDockPannel(dockPanel);
        }

        private void toolStripMenuItemJson_Click(object sender, EventArgs e)
        {
            new Form_JsonConvert().AddDockPannel(dockPanel);
        }

        private void toolStripMenuItemDirSet_Click(object sender, EventArgs e)
        {
            new Form_DirectorySettings().ShowDialog();
        }

        private void toolStripButton_CodeFile_Click(object sender, EventArgs e)
        {
            form_Database.BuilderSelect(CodeGenTarget.File);
        }

        private void toolStripButton_CodeDire_Click(object sender, EventArgs e)
        {
            form_Database.BuilderSelect(CodeGenTarget.Directories);
        }

        private void toolStripButtonWord_Click(object sender, EventArgs e)
        {
            new Form_ExportWord().ShowDialog();
        }
    }
}
