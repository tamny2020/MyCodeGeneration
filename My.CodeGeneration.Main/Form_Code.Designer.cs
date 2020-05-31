namespace My.CodeGeneration.Main
{
    partial class Form_Code
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
            this.textEditorCtl = new ICSharpCode.TextEditor.TextEditorControl();
            this.SuspendLayout();
            // 
            // textEditorCtl
            // 
            this.textEditorCtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditorCtl.IsReadOnly = false;
            this.textEditorCtl.Location = new System.Drawing.Point(0, 0);
            this.textEditorCtl.Name = "textEditorCtl";
            this.textEditorCtl.Size = new System.Drawing.Size(733, 399);
            this.textEditorCtl.TabIndex = 1;
            // 
            // Form_Code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 399);
            this.Controls.Add(this.textEditorCtl);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form_Code";
            this.ShowInTaskbar = false;
            this.Text = "Form_Code";
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl textEditorCtl;
    }
}