using NPOI.OpenXmlFormats.Wordprocessing;
using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My.CodeGeneration.Model;


namespace My.CodeGeneration.Common
{

    public class NPOIWordHelper
    {

        public static bool Create(string fileName, Dictionary<string, Tuple<string, List<Fields>>> dic)
        {
            var doc = new XWPFDocument();//创建document对象 
            foreach (var item in dic)
            {
                var p1 = doc.CreateParagraph();//创建段落对象
                var tbl = p1.CreateRun();
                tbl.FontSize = 15;
                tbl.SetBold(true);
                tbl.SetText(item.Key);

                var fields = item.Value.Item2;
                XWPFTable table = doc.CreateTable(fields.Count + 1, 5);
                table.Width = 1000 * 5;
                table.SetColumnWidth(0, 100);
                table.SetColumnWidth(1, 100);
                table.SetColumnWidth(2, 100);
                table.SetColumnWidth(3, 300);
                table.SetColumnWidth(4, 100);

                //表头
                table.GetRow(0).GetCell(0).SetParagraph(SetCellText(doc, table, "名称"));
                table.GetRow(0).GetCell(1).SetParagraph(SetCellText(doc, table, "类型"));
                table.GetRow(0).GetCell(2).SetParagraph(SetCellText(doc, table, "必须"));
                table.GetRow(0).GetCell(3).SetParagraph(SetCellText(doc, table, "描述"));
                table.GetRow(0).GetCell(4).SetParagraph(SetCellText(doc, table, "示例"));

                for (int i = 0; i < fields.Count; i++)
                {
                    var index = i + 1;
                    table.GetRow(index).GetCell(0).SetParagraph(SetCellText(doc, table, fields[i].Name));
                    table.GetRow(index).GetCell(1).SetParagraph(SetCellText(doc, table, fields[i].NetType));
                    table.GetRow(index).GetCell(2).SetParagraph(SetCellText(doc, table, fields[i].IsNull ? "否" : "是"));
                    table.GetRow(index).GetCell(3).SetParagraph(SetCellText(doc, table, fields[i].Note));
                    table.GetRow(index).GetCell(4).SetParagraph(SetCellText(doc, table, ""));
                }
            }
            using (FileStream sw = File.Create(fileName))
            {
                doc.Write(sw);
                sw.Close();
            }
            return true;
        }


        /// <summary>
        ///     设置字体格式
        /// </summary>
        /// <param name="doc"></param>
        /// <param name="table"></param>
        /// <param name="setText"></param>
        /// <returns></returns>
        public static XWPFParagraph SetCellText(XWPFDocument doc, XWPFTable table, string setText)
        {
            //table中的文字格式设置
            var para = new CT_P();
            var pCell = new XWPFParagraph(para, table.Body);
            pCell.Alignment = ParagraphAlignment.LEFT; //字体居中
            pCell.VerticalAlignment = TextAlignment.CENTER; ; //字体居中

            var r1c1 = pCell.CreateRun();
            r1c1.SetText(setText);
            //r1c1.FontSize = 13;
            //r1c1.SetFontFamily("华文楷体"); //设置雅黑字体

            return pCell;
        }
    }
}
