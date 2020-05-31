namespace My.CodeGeneration.Main
{
    partial class Form_JsonConvert
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
            this.textEditorControl_Out = new ICSharpCode.TextEditor.TextEditorControl();
            this.textEditorControl_Input = new ICSharpCode.TextEditor.TextEditorControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_CreateCode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEditorControl_Out
            // 
            this.textEditorControl_Out.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textEditorControl_Out.IsReadOnly = false;
            this.textEditorControl_Out.Location = new System.Drawing.Point(0, 388);
            this.textEditorControl_Out.Name = "textEditorControl_Out";
            this.textEditorControl_Out.Size = new System.Drawing.Size(911, 258);
            this.textEditorControl_Out.TabIndex = 0;
            // 
            // textEditorControl_Input
            // 
            this.textEditorControl_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditorControl_Input.IsReadOnly = false;
            this.textEditorControl_Input.Location = new System.Drawing.Point(0, 0);
            this.textEditorControl_Input.Name = "textEditorControl_Input";
            this.textEditorControl_Input.Size = new System.Drawing.Size(911, 317);
            this.textEditorControl_Input.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_CreateCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 65);
            this.panel1.TabIndex = 2;
            // 
            // button_CreateCode
            // 
            this.button_CreateCode.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_CreateCode.Location = new System.Drawing.Point(118, 18);
            this.button_CreateCode.Name = "button_CreateCode";
            this.button_CreateCode.Size = new System.Drawing.Size(75, 35);
            this.button_CreateCode.TabIndex = 0;
            this.button_CreateCode.Text = "生成代码";
            this.button_CreateCode.UseVisualStyleBackColor = true;
            this.button_CreateCode.Click += new System.EventHandler(this.button_CreateCode_Click);
            // 
            // Form_JsonConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textEditorControl_Input);
            this.Controls.Add(this.textEditorControl_Out);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form_JsonConvert";
            this.Text = "Json生成类在线生成工具";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ICSharpCode.TextEditor.TextEditorControl textEditorControl_Out;
        private ICSharpCode.TextEditor.TextEditorControl textEditorControl_Input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_CreateCode;
    }
}