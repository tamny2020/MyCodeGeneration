using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My.CodeGeneration.Common
{
    /// <summary>
    /// 集合分页
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagingList<T>
    {
        private List<T> dataList;
        /// <summary>
        /// 总记录数
        /// </summary>
        public int DataCount { get; set; }
        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount { get; set; }
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 每页显示记录数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 是否有上一页
        /// </summary>
        public bool HasPreviousPage
        {
            get { return PageIndex > 1; }
        }
        /// <summary>
        /// 是否有下一页
        /// </summary>
        public bool HasNextPage
        {
            get { return PageIndex < this.PageCount; }
        }
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="dataList"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        public PagingList(List<T> dataList, int pageSize)
        {
            this.dataList = dataList;
            this.PageSize = pageSize;
            this.DataCount = dataList.Count;
            this.PageCount = (int)Math.Ceiling((decimal)this.DataCount / pageSize);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public IEnumerable<T> GetList(int pageIndex)
        {
            this.PageIndex = pageIndex;
            return dataList.Skip((pageIndex - 1) * PageSize).Take(PageSize);
        }
    }
}
