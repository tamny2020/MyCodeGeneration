using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    public class ExcelHandler
    {
        private ExcelNPOI excel = null;
        public ExcelHandler()
        {
            excel = new ExcelNPOI();
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="absolutePath">文件绝对路径</param>
        /// <param name="sheetIndex">第几个表</param>
        public ExcelHandler(string absolutePath, int sheetIndex = 0)
        {
            excel = new ExcelNPOI(absolutePath, sheetIndex);
        }

        /// <summary>
        /// 把Excel读入DataTable中
        /// </summary>
        /// <param name="isHead">是否把第一行当数据 true是 false否</param>
        /// <returns></returns>
        public DataTable ReadExce2Table(bool isHead = false)
        {
            return excel.ReadExcelToDataTable(isHead);
        }

        /// <summary>
        /// 将DataTable生成Excel文件
        /// </summary>
        /// <param name="dt">传入DataTable</param>
        /// <param name="abPath">保存路径</param>
        /// <param name="fileName">导出时保存的文件名</param>
        /// <param name="tableHead">设置导出Excel表头信息 如果为null 不设置</param>
        public FileStream SaveExcelFile(DataTable dt, string savePath, string[] tableHead = null)
        {
            return excel.DataTableToExcelFile(dt, savePath, tableHead);
        }

    }
}
