using My.CodeGeneration.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using XPTable.Models;

namespace My.CodeGeneration.Main
{
    public partial class Form_TableDetail : DockContent
    {
        CellStyle cellCenterStyle = new CellStyle { Alignment = ColumnAlignment.Center };

        public Form_TableDetail(string title, List<Fields> fields)
        {
            InitializeComponent();
            this.Text = title;
            Bind(fields);


        }


        public void Bind(List<Fields> fields)
        {
            Table table = this.tableList;


            //Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NonClientAreaEnabled;
            //Application.EnableVisualStyles();


            var checkbox = new CheckBoxColumn("选择") { };
            var text_name = new TextColumn("字段名") { AutoResizeMode = ColumnAutoResizeMode.Shrink };
            //text_name.Alignment = ColumnAlignment.Center;AutoResizeMode = ColumnAutoResizeMode.Grow
            //text_desc.Editable = true;
            //text_desc.AutoResizeMode = ColumnAutoResizeMode.Any;
            var text_ident = new TextColumn("自增") { };
            var text_primaryKey = new TextColumn("主键") { };
            var text_type = new TextColumn("类型");
            var text_Length = new TextColumn("长度");
            var text_allowEmpty = new TextColumn("可空") { };
            var text_defaultValue = new TextColumn("默认值");
            var text_desc = new TextColumn("字段说明") { Width = 200 };

            var columnModel = new ColumnModel(new Column[] { 
                                                checkbox, 
                                                text_name, 
                                                text_ident, 
                                                text_primaryKey,
                                                text_type, 
                                                text_Length, 
                                                text_allowEmpty, 
                                                text_defaultValue,
                                                text_desc });

            var rowNum = fields.Count;
            Row[] rowList = new Row[rowNum];


            for (int i = 0; i < rowNum; i++)
            {
                var row = new Row();

                row.Cells.Add(new Cell("", cellCenterStyle) { Tag = fields[i] });
                row.Cells.Add(new Cell(fields[i].Name));
                row.Cells.Add(new Cell(fields[i].IsIdentity ? "是" : "否"));
                row.Cells.Add(new Cell(fields[i].IsPrimaryKey ? "是" : "否"));
                row.Cells.Add(new Cell(fields[i].NetType));
                row.Cells.Add(new Cell(fields[i].Length));
                row.Cells.Add(new Cell(fields[i].IsNull ? "是" : "否"));
                row.Cells.Add(new Cell(fields[i].Default));
                row.Cells.Add(new Cell(fields[i].Note));

                rowList[i] = row;
            }


            //table.Font = new Font(tableList.Font.FontFamily, 13f);
            table.SelectionStyle = SelectionStyle.Grid;
            table.BeginUpdate();
            table.EnableWordWrap = true;    // If false, then Cell.WordWrap is ignored
            table.FamilyRowSelect = true;
            table.FullRowSelect = true;
            table.ShowSelectionRectangle = false;
            table.MultiSelect = true;
            table.EnableWordWrap = false;
            table.GridLines = GridLines.Both;
            table.GridLinesContrainedToData = false;
            //this.tableList.BackColor = Color.AliceBlue;
            //table.SortedColumnBackColor = Color.FromArgb(100, Color.WhiteSmoke);
            table.FullRowSelect = true;
            table.HideSelection = false;
            //table.HeaderRenderer = new FlatHeaderRenderer();
            table.ColumnModel = columnModel;
            //table.HeaderFont = new Font("宋体", 13f);
            table.TableModel = new TableModel(rowList);
            table.TableModel.RowHeight = 21;
            table.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            table.HeaderAlignWithColumn = true;

            //this.tableList.GridLineStyle = GridLineStyle.Solid;

            table.BeginEditing += tableList_BeginEditing;
            this.tableList.EndUpdate();
        }

        void tableList_BeginEditing(object sender, XPTable.Events.CellEditEventArgs e)
        {
            // throw new NotImplementedException();
        }

        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            var list = GetCheckedFields();
        }

        /// <summary>
        /// 获取选中的字段
        /// </summary>
        /// <returns></returns>
        private List<Fields> GetCheckedFields()
        {
            List<Fields> list = new List<Fields>();
            foreach (Row row in this.tableList.TableModel.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    if (i == 0)
                    {
                        if (row.Cells[i].Checked)
                        {
                            list.Add(row.Cells[i].Tag as Fields);
                            break;
                        }
                    }
                }
            }
            return list;
        }

    }
}
