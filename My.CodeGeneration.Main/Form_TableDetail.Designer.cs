namespace My.CodeGeneration.Main
{
    partial class Form_TableDetail
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
            XPTable.Models.DataSourceColumnBinder dataSourceColumnBinder9 = new XPTable.Models.DataSourceColumnBinder();
            XPTable.Renderers.DragDropRenderer dragDropRenderer9 = new XPTable.Renderers.DragDropRenderer();
            this.btnCreateCode = new System.Windows.Forms.Button();
            this.tableList = new XPTable.Models.Table();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tableList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.Location = new System.Drawing.Point(27, 18);
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.Size = new System.Drawing.Size(90, 33);
            this.btnCreateCode.TabIndex = 0;
            this.btnCreateCode.Text = "生成代码";
            this.btnCreateCode.UseVisualStyleBackColor = true;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // tableList
            // 
            this.tableList.BorderColor = System.Drawing.Color.Black;
            this.tableList.DataMember = null;
            this.tableList.DataSourceColumnBinder = dataSourceColumnBinder9;
            this.tableList.Dock = System.Windows.Forms.DockStyle.Top;
            dragDropRenderer9.ForeColor = System.Drawing.Color.Red;
            this.tableList.DragDropRenderer = dragDropRenderer9;
            this.tableList.GridLinesContrainedToData = false;
            this.tableList.Location = new System.Drawing.Point(0, 0);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(1007, 279);
            this.tableList.TabIndex = 12;
            this.tableList.Text = "table1";
            this.tableList.UnfocusedBorderColor = System.Drawing.Color.Black;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btnCreateCode);
            this.panel1.Location = new System.Drawing.Point(0, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 74);
            this.panel1.TabIndex = 13;
            // 
            // Form_TableDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableList);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form_TableDetail";
            this.Text = "Form_TableDetail";
            ((System.ComponentModel.ISupportInitialize)(this.tableList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCode;
        private XPTable.Models.Table tableList;
        private System.Windows.Forms.Panel panel1;

    }
}