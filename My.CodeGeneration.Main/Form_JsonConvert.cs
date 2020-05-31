using ICSharpCode.TextEditor.Document;
using My.CodeGeneration.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My.CodeGeneration.Main
{
    public partial class Form_JsonConvert : Form_Base
    {
        public Form_JsonConvert()
        {
            InitializeComponent();

            this.textEditorControl_Input.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy(ConstValue.CSharp);
            this.textEditorControl_Out.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy(ConstValue.CSharp);
            this.textEditorControl_Out.Encoding = this.textEditorControl_Input.Encoding = System.Text.Encoding.Default;
            this.textEditorControl_Out.Text = this.textEditorControl_Input.Text = "";
        }

        private void button_CreateCode_Click(object sender, EventArgs e)
        {
            var tf = new JsonTransformClass("MyClass", this.textEditorControl_Input.Text.Trim());
            this.textEditorControl_Out.Text = tf.BuilderClass();
        }
    }
}
