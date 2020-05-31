namespace My.CodeGeneration.Main
{
    partial class Form_AddServerMySql
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_mysql = new System.Windows.Forms.Panel();
            this.button_mysqladd = new System.Windows.Forms.Button();
            this.button_mysqltest = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox_mysql_port = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_mysql_pwd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_mysql_uid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_mysql_server = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_mysql.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mysql
            // 
            this.panel_mysql.Controls.Add(this.button_mysqladd);
            this.panel_mysql.Controls.Add(this.button_mysqltest);
            this.panel_mysql.Controls.Add(this.btnBack);
            this.panel_mysql.Controls.Add(this.textBox_mysql_port);
            this.panel_mysql.Controls.Add(this.label12);
            this.panel_mysql.Controls.Add(this.textBox_mysql_pwd);
            this.panel_mysql.Controls.Add(this.label9);
            this.panel_mysql.Controls.Add(this.textBox_mysql_uid);
            this.panel_mysql.Controls.Add(this.label10);
            this.panel_mysql.Controls.Add(this.comboBox_mysql_server);
            this.panel_mysql.Controls.Add(this.label11);
            this.panel_mysql.Location = new System.Drawing.Point(22, 12);
            this.panel_mysql.Name = "panel_mysql";
            this.panel_mysql.Size = new System.Drawing.Size(451, 241);
            this.panel_mysql.TabIndex = 4;
            // 
            // button_mysqladd
            // 
            this.button_mysqladd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_mysqladd.Location = new System.Drawing.Point(302, 186);
            this.button_mysqladd.Name = "button_mysqladd";
            this.button_mysqladd.Size = new System.Drawing.Size(93, 28);
            this.button_mysqladd.TabIndex = 29;
            this.button_mysqladd.Text = "添加连接";
            this.button_mysqladd.UseVisualStyleBackColor = true;
            // 
            // button_mysqltest
            // 
            this.button_mysqltest.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_mysqltest.Location = new System.Drawing.Point(203, 186);
            this.button_mysqltest.Name = "button_mysqltest";
            this.button_mysqltest.Size = new System.Drawing.Size(75, 28);
            this.button_mysqltest.TabIndex = 28;
            this.button_mysqltest.Text = "测试连接";
            this.button_mysqltest.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(101, 186);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "上一步";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBox_mysql_port
            // 
            this.textBox_mysql_port.Location = new System.Drawing.Point(169, 143);
            this.textBox_mysql_port.Name = "textBox_mysql_port";
            this.textBox_mysql_port.Size = new System.Drawing.Size(161, 21);
            this.textBox_mysql_port.TabIndex = 26;
            this.textBox_mysql_port.Text = "3306";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(122, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 14);
            this.label12.TabIndex = 25;
            this.label12.Text = "端口：";
            // 
            // textBox_mysql_pwd
            // 
            this.textBox_mysql_pwd.Location = new System.Drawing.Point(169, 108);
            this.textBox_mysql_pwd.Name = "textBox_mysql_pwd";
            this.textBox_mysql_pwd.PasswordChar = '*';
            this.textBox_mysql_pwd.Size = new System.Drawing.Size(161, 21);
            this.textBox_mysql_pwd.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(122, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 23;
            this.label9.Text = "密码：";
            // 
            // textBox_mysql_uid
            // 
            this.textBox_mysql_uid.Location = new System.Drawing.Point(169, 70);
            this.textBox_mysql_uid.Name = "textBox_mysql_uid";
            this.textBox_mysql_uid.Size = new System.Drawing.Size(161, 21);
            this.textBox_mysql_uid.TabIndex = 22;
            this.textBox_mysql_uid.Text = "root";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(110, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 14);
            this.label10.TabIndex = 21;
            this.label10.Text = "登录名：";
            // 
            // comboBox_mysql_server
            // 
            this.comboBox_mysql_server.FormattingEnabled = true;
            this.comboBox_mysql_server.Location = new System.Drawing.Point(169, 34);
            this.comboBox_mysql_server.Name = "comboBox_mysql_server";
            this.comboBox_mysql_server.Size = new System.Drawing.Size(161, 20);
            this.comboBox_mysql_server.TabIndex = 20;
            this.comboBox_mysql_server.Text = "127.0.0.1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(110, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 14);
            this.label11.TabIndex = 19;
            this.label11.Text = "服务器：";
            // 
            // Form_AddServerMySql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 276);
            this.Controls.Add(this.panel_mysql);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddServerMySql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Content to MySQL Host";
            this.panel_mysql.ResumeLayout(false);
            this.panel_mysql.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mysql;
        private System.Windows.Forms.Button button_mysqladd;
        private System.Windows.Forms.Button button_mysqltest;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox_mysql_port;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_mysql_pwd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_mysql_uid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_mysql_server;
        private System.Windows.Forms.Label label11;
    }
}