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
    public partial class Form_AddServerMySql : Form
    {
        public Form_AddServerMySql()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_AddServer fas = new Form_AddServer();
            fas.ShowDialog();
            this.Close();
        }
    }
}
