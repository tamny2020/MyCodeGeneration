namespace My.CodeGeneration.Main
{
    partial class Form_ClassConvert
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
            this.textEditorControl_Input = new ICSharpCode.TextEditor.TextEditorControl();
            this.textEditorControl_Out = new ICSharpCode.TextEditor.TextEditorControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_BuilderQuery = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditorControl_Input
            // 
            this.textEditorControl_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditorControl_Input.IsReadOnly = false;
            this.textEditorControl_Input.Location = new System.Drawing.Point(0, 0);
            this.textEditorControl_Input.Name = "textEditorControl_Input";
            this.textEditorControl_Input.Size = new System.Drawing.Size(1084, 320);
            this.textEditorControl_Input.TabIndex = 0;
            // 
            // textEditorControl_Out
            // 
            this.textEditorControl_Out.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textEditorControl_Out.IsReadOnly = false;
            this.textEditorControl_Out.Location = new System.Drawing.Point(0, 394);
            this.textEditorControl_Out.Name = "textEditorControl_Out";
            this.textEditorControl_Out.Size = new System.Drawing.Size(1084, 267);
            this.textEditorControl_Out.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_BuilderQuery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 326);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 68);
            this.panel1.TabIndex = 4;
            // 
            // button_BuilderQuery
            // 
            this.button_BuilderQuery.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_BuilderQuery.Location = new System.Drawing.Point(289, 12);
            this.button_BuilderQuery.Name = "button_BuilderQuery";
            this.button_BuilderQuery.Size = new System.Drawing.Size(100, 39);
            this.button_BuilderQuery.TabIndex = 1;
            this.button_BuilderQuery.Text = "生成查询";
            this.button_BuilderQuery.UseVisualStyleBackColor = true;
            this.button_BuilderQuery.Click += new System.EventHandler(this.button_BuilderQuery_Click);
            // 
            // Form_ClassConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textEditorControl_Out);
            this.Controls.Add(this.textEditorControl_Input);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form_ClassConvert";
            this.Text = "实体类转化工具";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl textEditorControl_Input;
        private ICSharpCode.TextEditor.TextEditorControl textEditorControl_Out;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_BuilderQuery;
    }
}