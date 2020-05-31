using My.CodeGeneration.Business;
using My.CodeGeneration.Common;
using My.CodeGeneration.Model;
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
    public partial class Form_AddServerSqlServer : Form
    {
        public Form_AddServerSqlServer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_AddServer fas = new Form_AddServer();
            fas.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.btnTest.Enabled = false;

            var server = this.server.Text.Trim();
            var uid = this.uid.Text.Trim();
            var pwd = this.pwd.Text.Trim();

            var model = new Servers
            {
                Id = CommonHelper.NewGuid,
                Name = server,
                Type = DatabaseType.SqlServer,
                Server = server,
                Uid = uid,
                Pwd = pwd
            };
            ServersHelper.AddServers(model);

            //var model = new ConfigServers
            //{
            //    Id = CommonHelper.NewGuid,
            //    Name = string.Format("{0}({1})", server, DatabaseType.SqlServer.ToString()),
            //    Type = DatabaseType.SqlServer.ToString(),
            //    Server = server,
            //    Uid = uid,
            //    Pwd = pwd,
            //};
            //ServersConfigClass.Instance.Add(model);

            string err;
            var b = new BLL_Database(DatabaseType.SqlServer).TestDatabaseConnnection(model.Id, out err);
            if (!b)
            {
                MessageBox.Show(err, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("连接成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            this.btnTest.Enabled = true;
        }

    }
}
