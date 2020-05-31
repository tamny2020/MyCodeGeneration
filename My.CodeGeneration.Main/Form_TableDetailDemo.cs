using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XPTable.Events;
using XPTable.Models;
using XPTable.Renderers;
using XPTable.Themes;

namespace My.CodeGeneration.Main
{
    /// <summary>
    /// Form_TableDetail
    /// </summary>
    public partial class Form_TableDetailDemo : Form_Base
    {

        public Form_TableDetailDemo()
        {
            InitializeComponent();

            Table table = this.tableList;

            //Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NonClientAreaEnabled;
            //Application.EnableVisualStyles();


            var checkbox_sel = new CheckBoxColumn("选择");
            var combobox_search = new ComboBoxColumn("搜索类型");
            var text_name = new TextColumn("字段");
            //text_name.Alignment = ColumnAlignment.Center;
            text_name.AutoResizeMode = ColumnAutoResizeMode.Grow;


            var text_desc = new TextColumn("字段说明");
            //text_desc.Editable = true;
            //text_desc.AutoResizeMode = ColumnAutoResizeMode.Any;


            var text_Ident = new TextColumn("标识");
            var text_type = new TextColumn("类型");
            var text_Length = new TextColumn("长度");
            var text_allowEmpty = new TextColumn("为空");
            var text_addDesc = new TextColumn("添加说明");



            var columnModel = new ColumnModel(new Column[] { checkbox_sel, text_name, text_desc, text_Ident, text_type, text_Length, text_allowEmpty, text_addDesc });

            Row[] rowList = new Row[8];

            for (int i = 0; i < 8; i++)
            {
                var r = new Row();
                r.Cells.Add(new Cell("", false));
                r.Cells.Add(new Cell("dd", new CellStyle() { Alignment = ColumnAlignment.Left }));
                r.Cells.Add(new Cell("dd"));
                r.Cells.Add(new Cell("dd"));
                r.Cells.Add(new Cell("dd"));
                r.Cells.Add(new Cell("dd"));
                r.Cells.Add(new Cell("dd"));
                r.Cells.Add(new Cell("dd"));
                rowList[i] = r;
            }


            table.Font = new Font(tableList.Font.FontFamily, 13f);
            table.SelectionStyle = SelectionStyle.Grid;

            table.BeginUpdate();


            table.EnableWordWrap = true;    // If false, then Cell.WordWrap is ignored
            table.FamilyRowSelect = true;
            table.FullRowSelect = true;
            table.ShowSelectionRectangle = false;
            table.MultiSelect = true;
            table.EnableWordWrap = false;
            table.GridLines = GridLines.Both;
            //table.GridLinesContrainedToData = true;

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

    }

}
