using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonDemo1_1763
{
    /// <summary>
    /// 休假
    /// </summary>
    public class Vacation
    {
        /// <summary>
        /// 特休資訊
        /// </summary>
        public string Type { get; set; } = "特休資訊";
        /// <summary>
        /// 同仁姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 總時數
        /// </summary>
        public int TotalHours { get; set; }
        /// <summary>
        /// 未排
        /// </summary>
        public int NoSelect { get; set; }
        /// <summary>
        /// 已排
        /// </summary>
        public int IsSelect { get; set; }
        /// <summary>
        /// 已休
        /// </summary>
        public int TakeRest { get; set; }

        /// <summary>
        /// 剩餘
        /// </summary>
        [JsonIgnore]
        public  string Remaining { get; set; }
        /// <summary>
        /// 剩餘百分比
        /// </summary>
        public string RemainingPercentage { get { return $"{Remaining}%"; } }
}
}
