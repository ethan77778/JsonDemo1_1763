using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo1_1763
{
    /// <summary>
    /// 簽到
    /// </summary>
    public class CheckIn
    {
        //public string Type { get; set; } = "登入資訊";
        /// <summary>
        /// 本日登入
        /// </summary>
        public string TodayCheckIn{ get; set; }
        /// <summary>
        /// 上次登入
        /// </summary>
        public string LastLogin { get; set; }
    }
}
