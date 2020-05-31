namespace My.CodeGeneration.Main
{
    partial class Form_Database
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Database));
            this.toolStripBar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.treeViewLeft = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCodeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCodeDir = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripBar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripBar
            // 
            this.toolStripBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripButton3});
            this.toolStripBar.Location = new System.Drawing.Point(0, 0);
            this.toolStripBar.Name = "toolStripBar";
            this.toolStripBar.Size = new System.Drawing.Size(249, 25);
            this.toolStripBar.TabIndex = 1;
            this.toolStripBar.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "添加数据库服务器";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "注销数据库服务器";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "刷新";
            // 
            // treeViewLeft
            // 
            this.treeViewLeft.CheckBoxes = true;
            this.treeViewLeft.ContextMenuStrip = this.contextMenuStrip1;
            this.treeViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewLeft.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeViewLeft.HideSelection = false;
            this.treeViewLeft.ImageIndex = 0;
            this.treeViewLeft.ImageList = this.imageList1;
            this.treeViewLeft.Location = new System.Drawing.Point(0, 25);
            this.treeViewLeft.Name = "treeViewLeft";
            this.treeViewLeft.SelectedImageIndex = 0;
            this.treeViewLeft.ShowRootLines = false;
            this.treeViewLeft.Size = new System.Drawing.Size(249, 527);
            this.treeViewLeft.TabIndex = 2;
            this.treeViewLeft.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewLeft_AfterCheck);
            this.treeViewLeft.DoubleClick += new System.EventHandler(this.treeViewLeft_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripRefresh,
            this.toolStripSeparator2,
            this.toolStripMenuItemCodeFile,
            this.toolStripMenuItemCodeDir});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 98);
            // 
            // menuStripRefresh
            // 
            this.menuStripRefresh.Image = ((System.Drawing.Image)(resources.GetObject("menuStripRefresh.Image")));
            this.menuStripRefresh.Name = "menuStripRefresh";
            this.menuStripRefresh.Size = new System.Drawing.Size(160, 22);
            this.menuStripRefresh.Text = "刷新";
            this.menuStripRefresh.Click += new System.EventHandler(this.menuStripRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // toolStripMenuItemCodeFile
            // 
            this.toolStripMenuItemCodeFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCodeFile.Image")));
            this.toolStripMenuItemCodeFile.Name = "toolStripMenuItemCodeFile";
            this.toolStripMenuItemCodeFile.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemCodeFile.Text = "生成代码至文件";
            this.toolStripMenuItemCodeFile.Click += new System.EventHandler(this.toolStripMenuItemCodeFile_Click);
            // 
            // toolStripMenuItemCodeDir
            // 
            this.toolStripMenuItemCodeDir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCodeDir.Image")));
            this.toolStripMenuItemCodeDir.Name = "toolStripMenuItemCodeDir";
            this.toolStripMenuItemCodeDir.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemCodeDir.Text = "生成代码至目录";
            this.toolStripMenuItemCodeDir.Click += new System.EventHandler(this.toolStripMenuItemCodeDir_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "(36,46).png");
            this.imageList1.Images.SetKeyName(1, "(42,48).png");
            this.imageList1.Images.SetKeyName(2, "(18,12).png");
            this.imageList1.Images.SetKeyName(3, "(11,30).png");
            this.imageList1.Images.SetKeyName(4, "(02,29).png");
            this.imageList1.Images.SetKeyName(5, "pri.png");
            // 
            // Form_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 552);
            this.Controls.Add(this.treeViewLeft);
            this.Controls.Add(this.toolStripBar);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form_Database";
            this.Text = "数据库存服务器";
            this.Load += new System.EventHandler(this.Form_Database_Load);
            this.DoubleClick += new System.EventHandler(this.Form_Database_DoubleClick);
            this.toolStripBar.ResumeLayout(false);
            this.toolStripBar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripBar;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        public System.Windows.Forms.TreeView treeViewLeft;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStripRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCodeFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCodeDir;
        private System.Windows.Forms.ImageList imageList1;
    }
}