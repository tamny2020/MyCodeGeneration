namespace My.CodeGeneration.Main
{
    partial class Form_AddServerSqlServer
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
            this.panel_sqlserver = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_sqlserver.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_sqlserver
            // 
            this.panel_sqlserver.Controls.Add(this.btnAdd);
            this.panel_sqlserver.Controls.Add(this.btnTest);
            this.panel_sqlserver.Controls.Add(this.btnBack);
            this.panel_sqlserver.Controls.Add(this.pwd);
            this.panel_sqlserver.Controls.Add(this.label5);
            this.panel_sqlserver.Controls.Add(this.uid);
            this.panel_sqlserver.Controls.Add(this.label4);
            this.panel_sqlserver.Controls.Add(this.server);
            this.panel_sqlserver.Controls.Add(this.label3);
            this.panel_sqlserver.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel_sqlserver.Location = new System.Drawing.Point(59, 12);
            this.panel_sqlserver.Name = "panel_sqlserver";
            this.panel_sqlserver.Size = new System.Drawing.Size(412, 232);
            this.panel_sqlserver.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(227, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 28);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "添加连接";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTest.Location = new System.Drawing.Point(143, 189);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 28);
            this.btnTest.TabIndex = 22;
            this.btnTest.Text = "测试连接";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(57, 189);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 28);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "上一步";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(128, 123);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(161, 23);
            this.pwd.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "密码：";
            // 
            // uid
            // 
            this.uid.Location = new System.Drawing.Point(128, 85);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(161, 23);
            this.uid.TabIndex = 16;
            this.uid.Text = "sa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "登录名：";
            // 
            // server
            // 
            this.server.FormattingEnabled = true;
            this.server.Location = new System.Drawing.Point(128, 49);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(161, 21);
            this.server.TabIndex = 14;
            this.server.Text = ".\\SQLEXPRESS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 13;
            this.label3.Text = "服务器：";
            // 
            // Form_AddServerSqlServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 276);
            this.Controls.Add(this.panel_sqlserver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddServerSqlServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Content to SqlServer Host";
            this.panel_sqlserver.ResumeLayout(false);
            this.panel_sqlserver.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_sqlserver;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox server;
        private System.Windows.Forms.Label label3;

    }
}