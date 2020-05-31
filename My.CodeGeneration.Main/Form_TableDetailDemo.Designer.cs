namespace My.CodeGeneration.Main
{
    partial class Form_TableDetailDemo
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
            XPTable.Models.DataSourceColumnBinder dataSourceColumnBinder1 = new XPTable.Models.DataSourceColumnBinder();
            XPTable.Renderers.DragDropRenderer dragDropRenderer1 = new XPTable.Renderers.DragDropRenderer();
            this.tableList = new XPTable.Models.Table();
            ((System.ComponentModel.ISupportInitialize)(this.tableList)).BeginInit();
            this.SuspendLayout();
            // 
            // tableList
            // 
            this.tableList.BorderColor = System.Drawing.Color.Black;
            this.tableList.DataMember = null;
            this.tableList.DataSourceColumnBinder = dataSourceColumnBinder1;
            this.tableList.Dock = System.Windows.Forms.DockStyle.Top;
            dragDropRenderer1.ForeColor = System.Drawing.Color.Red;
            this.tableList.DragDropRenderer = dragDropRenderer1;
            this.tableList.GridLinesContrainedToData = false;
            this.tableList.Location = new System.Drawing.Point(0, 0);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(705, 324);
            this.tableList.TabIndex = 0;
            this.tableList.Text = "table1";
            this.tableList.UnfocusedBorderColor = System.Drawing.Color.Black;
            // 
            // Form_TableDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 493);
            this.Controls.Add(this.tableList);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form_TableDetail";
            this.Text = "Form_TableDetail";
            ((System.ComponentModel.ISupportInitialize)(this.tableList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XPTable.Models.Table tableList;

    }
}