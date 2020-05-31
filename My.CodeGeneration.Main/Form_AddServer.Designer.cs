namespace My.CodeGeneration.Main
{
    partial class Form_AddServer
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
            this.panel_RadioButton = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.radioButton_Sqlite = new System.Windows.Forms.RadioButton();
            this.radioButton_Access = new System.Windows.Forms.RadioButton();
            this.radioButton_Mysql = new System.Windows.Forms.RadioButton();
            this.radioButton_Oracle = new System.Windows.Forms.RadioButton();
            this.radioButton_Sqlserver = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_RadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_RadioButton
            // 
            this.panel_RadioButton.Controls.Add(this.btnNext);
            this.panel_RadioButton.Controls.Add(this.radioButton_Sqlite);
            this.panel_RadioButton.Controls.Add(this.radioButton_Access);
            this.panel_RadioButton.Controls.Add(this.radioButton_Mysql);
            this.panel_RadioButton.Controls.Add(this.radioButton_Oracle);
            this.panel_RadioButton.Controls.Add(this.radioButton_Sqlserver);
            this.panel_RadioButton.Controls.Add(this.label1);
            this.panel_RadioButton.Location = new System.Drawing.Point(61, 29);
            this.panel_RadioButton.Name = "panel_RadioButton";
            this.panel_RadioButton.Size = new System.Drawing.Size(377, 215);
            this.panel_RadioButton.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(129, 163);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 33);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "下一步";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // radioButton_Sqlite
            // 
            this.radioButton_Sqlite.AutoSize = true;
            this.radioButton_Sqlite.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Sqlite.Location = new System.Drawing.Point(129, 126);
            this.radioButton_Sqlite.Name = "radioButton_Sqlite";
            this.radioButton_Sqlite.Size = new System.Drawing.Size(67, 18);
            this.radioButton_Sqlite.TabIndex = 7;
            this.radioButton_Sqlite.Text = "Sqlite";
            this.radioButton_Sqlite.UseVisualStyleBackColor = true;
            // 
            // radioButton_Access
            // 
            this.radioButton_Access.AutoSize = true;
            this.radioButton_Access.Enabled = false;
            this.radioButton_Access.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Access.Location = new System.Drawing.Point(129, 104);
            this.radioButton_Access.Name = "radioButton_Access";
            this.radioButton_Access.Size = new System.Drawing.Size(67, 18);
            this.radioButton_Access.TabIndex = 6;
            this.radioButton_Access.Text = "Access";
            this.radioButton_Access.UseVisualStyleBackColor = true;
            // 
            // radioButton_Mysql
            // 
            this.radioButton_Mysql.AutoSize = true;
            this.radioButton_Mysql.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Mysql.Location = new System.Drawing.Point(129, 82);
            this.radioButton_Mysql.Name = "radioButton_Mysql";
            this.radioButton_Mysql.Size = new System.Drawing.Size(60, 18);
            this.radioButton_Mysql.TabIndex = 5;
            this.radioButton_Mysql.Text = "MySql";
            this.radioButton_Mysql.UseVisualStyleBackColor = true;
            // 
            // radioButton_Oracle
            // 
            this.radioButton_Oracle.AutoSize = true;
            this.radioButton_Oracle.Enabled = false;
            this.radioButton_Oracle.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Oracle.Location = new System.Drawing.Point(129, 60);
            this.radioButton_Oracle.Name = "radioButton_Oracle";
            this.radioButton_Oracle.Size = new System.Drawing.Size(67, 18);
            this.radioButton_Oracle.TabIndex = 4;
            this.radioButton_Oracle.Text = "Oracle";
            this.radioButton_Oracle.UseVisualStyleBackColor = true;
            // 
            // radioButton_Sqlserver
            // 
            this.radioButton_Sqlserver.AutoSize = true;
            this.radioButton_Sqlserver.Checked = true;
            this.radioButton_Sqlserver.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton_Sqlserver.Location = new System.Drawing.Point(129, 38);
            this.radioButton_Sqlserver.Name = "radioButton_Sqlserver";
            this.radioButton_Sqlserver.Size = new System.Drawing.Size(88, 18);
            this.radioButton_Sqlserver.TabIndex = 2;
            this.radioButton_Sqlserver.TabStop = true;
            this.radioButton_Sqlserver.Text = "SqlServer";
            this.radioButton_Sqlserver.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库类型：";
            // 
            // Form_AddServers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 276);
            this.Controls.Add(this.panel_RadioButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_AddServers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加数据库服务器";
            this.panel_RadioButton.ResumeLayout(false);
            this.panel_RadioButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_RadioButton;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton radioButton_Sqlite;
        private System.Windows.Forms.RadioButton radioButton_Access;
        private System.Windows.Forms.RadioButton radioButton_Mysql;
        private System.Windows.Forms.RadioButton radioButton_Oracle;
        private System.Windows.Forms.RadioButton radioButton_Sqlserver;
        private System.Windows.Forms.Label label1;
    }
}