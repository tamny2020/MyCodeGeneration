using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace My.CodeGeneration.Main
{
    public static class ShellExtension
    {
        /// <summary>
        /// AddDockPannel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="form"></param>
        /// <param name="dockPanel"></param>
        public static void AddDockPannel<T>(this T form, DockPanel dockPanel, DockState dockState = DockState.Document) where T : DockContent
        {
            form.Show(dockPanel, dockState);
        }
    }
}
