using ICSharpCode.TextEditor.Document;
using My.CodeGeneration.Model.Enum;
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
    public partial class Form_Code : Form_Base
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="content">内容</param>
        /// <param name="codeTypeName">代码类型名称</param>
        public Form_Code(string title, string content, string codeTypeName)
        {
            InitializeComponent();
            this.Text = title;

            //this.textEditorCtl.ShowEOLMarkers = false;
            //this.textEditorCtl.ShowHRuler = false;
            //this.textEditorCtl.ShowInvalidLines = false;
            //this.textEditorCtl.ShowMatchingBracket = true;
            //this.textEditorCtl.ShowSpaces = false;
            //this.textEditorCtl.ShowTabs = false;
            //this.textEditorCtl.ShowVRuler = false;
            //this.textEditorCtl.AllowCaretBeyondEOL = false;

            //让其支持中文
            //支持指定的语法高亮显示 HTML,Java PHP XML JavaScript BAT
            this.textEditorCtl.Document.HighlightingStrategy = HighlightingStrategyFactory.CreateHighlightingStrategy(codeTypeName);
            this.textEditorCtl.Encoding = System.Text.Encoding.Default;
            this.textEditorCtl.Text = content;
        }

    }
}
