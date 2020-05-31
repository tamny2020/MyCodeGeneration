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

namespace My.CodeGeneration.Main
{
    public partial class Form_AddServer : Form
    {
        public Form_AddServer()
        {
            InitializeComponent();

        }

        public DatabaseType GetDatabaseType()
        {
            DatabaseType type = DatabaseType.None;
            foreach (Control item in panel_RadioButton.Controls)
            {
                if (item is RadioButton)
                {
                    var radioButton = (RadioButton)item;
                    if (radioButton.Checked)
                    {
                        type = (DatabaseType)Enum.Parse(typeof(DatabaseType), radioButton.Text);
                        break;
                    }
                }
            }
            return type;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var type = GetDatabaseType();
            switch (type)
            {
                case DatabaseType.SqlServer:
                    this.Close();
                    var sqlServerForm = new Form_AddServerSqlServer();
                    sqlServerForm.ShowDialog();
                    break;
                case DatabaseType.Access:
                    break;
                case DatabaseType.MySql:
                    this.Close();
                    var mySqlForm = new Form_AddServerMySql();
                    mySqlForm.ShowDialog();
                    break;
                case DatabaseType.Sqlite:
                    break;
                case DatabaseType.Oracle:
                    break;
                default:
                    break;
            }
        }
    }
}
