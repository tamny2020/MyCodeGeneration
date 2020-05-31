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
    public partial class Form_Index : DockContent
    {
        public static Form_Index Instance = null;
        public static Form_Home form_Home = null;
        public static Form_Database form_Database = null;
        public Form_Index()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Index_Load(object sender, EventArgs e)
        {
            form_Database = new Form_Database();
            form_Database.Show(dockPanel, DockState.DockLeft);

            form_Home = new Form_Home();
            form_Home.Show(dockPanel);
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

            AddDockPannel(new Form_ClassConvert());
        }

        private void toolStripMenuItemJson_Click(object sender, EventArgs e)
        {
            AddDockPannel(new Form_JsonConvert());
        }

        public void AddDockPannel<T>(T form) where T : DockContent
        {
            form.Show(dockPanel);
        }

        private void toolStripMenuItemDirSet_Click(object sender, EventArgs e)
        {
           var form= new Form_DirectorySettings();
           form.ShowDialog();
        }
    }
}
