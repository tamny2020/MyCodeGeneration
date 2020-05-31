namespace My.CodeGeneration.Main
{
    partial class Form_BuilderSelect
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
            this.tableModel1 = new XPTable.Models.TableModel();
            this.btnCreateCode = new System.Windows.Forms.Button();
            this.tableList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCreateCode
            // 
            this.btnCreateCode.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCreateCode.Location = new System.Drawing.Point(218, 243);
            this.btnCreateCode.Name = "btnCreateCode";
            this.btnCreateCode.Size = new System.Drawing.Size(114, 46);
            this.btnCreateCode.TabIndex = 17;
            this.btnCreateCode.Text = "生成代码";
            this.btnCreateCode.UseVisualStyleBackColor = true;
            this.btnCreateCode.Click += new System.EventHandler(this.btnCreateCode_Click);
            // 
            // tableList
            // 
            this.tableList.CheckBoxes = true;
            this.tableList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.tableList.Location = new System.Drawing.Point(53, 31);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(462, 194);
            this.tableList.TabIndex = 19;
            this.tableList.UseCompatibleStateImageBehavior = false;
            this.tableList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "选择";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "模板名称";
            this.columnHeader3.Width = 300;
            // 
            // Form_BuilderSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 317);
            this.Controls.Add(this.tableList);
            this.Controls.Add(this.btnCreateCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_BuilderSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码生成模板选择";
            this.ResumeLayout(false);

        }

        #endregion

        private XPTable.Models.TableModel tableModel1;
        private System.Windows.Forms.Button btnCreateCode;
        private System.Windows.Forms.ListView tableList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}