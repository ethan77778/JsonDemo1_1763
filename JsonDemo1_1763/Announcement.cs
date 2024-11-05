using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo1_1763
{
    /// <summary>
    /// 公告專區
    /// </summary>
    public class Announcement
    {
        public string Type { get; set; } = "公告區域";
        /// <summary>
        /// 公告類別
        /// </summary>
       public string AnnouncementCategory { get; set; }
        /// <summary>
        /// 公告內容
        /// </summary>
        public List<Content>? Contents { get; set; }

    }
}
