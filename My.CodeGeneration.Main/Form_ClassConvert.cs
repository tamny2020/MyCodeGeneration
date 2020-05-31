using ICSharpCode.TextEditor.Document;
using My.CodeGeneration.Business;
using My.CodeGeneration.Common;
using My.CodeGeneration.Model;
using Newtonsoft.Json;
using RazorEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace My.CodeGeneration.Main
{
    public partial class Form_ClassConvert : Form_Base
    {

        public Form_ClassConvert()
        {
            InitializeComponent();

            this.textEditorControl_Input.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy(ConstValue.HTML);
            this.textEditorControl_Out.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy(ConstValue.CSharp);
            this.textEditorControl_Out.Encoding = this.textEditorControl_Input.Encoding = System.Text.Encoding.Default;
            this.textEditorControl_Out.Text = this.textEditorControl_Input.Text = "";
        }

        private void button_BuilderQuery_Click(object sender, EventArgs e)
        {
            Execute(() =>
            {
                var list = CommonHelper.ParseClassPropertityList(this.textEditorControl_Input.Text);
                var parseHtml = RazorEngineExtension.Parse(CommonHelper.Resources + @"\Query_html.cshtml", list);
                this.textEditorControl_Out.Text = parseHtml;
            });
        }

        private void button_BuilderJson_Click(object sender, EventArgs e)
        {

        }

        private void button_BuilderColumn_Click(object sender, EventArgs e)
        {
            Execute(() =>
            {
                string textEditor = this.textEditorControl_Input.Text.Trim();
                var list = CommonHelper.ParseClassPropertityList(textEditor);
                textEditorControl_Out.Text = JsonConvert.SerializeObject(list.Select(x => x.Name));
            });
        }

    }
}
