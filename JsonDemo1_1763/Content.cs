using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo1_1763
{
    /// <summary>
    /// 公告內容
    /// </summary>
    public class Content
    {
        /// <summary>
        /// 內容編號
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 標題
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 發佈人
        /// </summary>
        public string Name { get; set; }
    }
}
