using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My.CodeGeneration.Main
{
    public partial class Form_Base : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public Form_Base()
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form_Base
            // 
            this.ClientSize = new System.Drawing.Size(422, 393);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "Form_Base";
            this.ResumeLayout(false);
        }

        public static void ShowBox(string msg, string caption = "消息提示", MessageBoxIcon icon = MessageBoxIcon.Information, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            MessageBox.Show(msg, caption, buttons, icon);
        }


        public static void Execute(Action deleteAction)
        {
            try
            {
                deleteAction();
            }
            catch (Exception ex)
            {
                ShowBox(ex.Message, "异常", MessageBoxIcon.Error);
            }
        }

       
    }
}
