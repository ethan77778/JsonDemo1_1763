using Newtonsoft.Json;

namespace JsonDemo1_1763
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var AnnouncementInformation = new List<Announcement>
                {
                     new Announcement
                {
                    AnnouncementCategory="行政公告",
                    Contents=null

                },
                new Announcement
                {
                    AnnouncementCategory="生活花絮",
                    Contents=null

                },
                new Announcement
                {
                    AnnouncementCategory="資安公告",
                    Contents=new List<Content>
                    {
                        new Content
                        {
                            Id=1,
                            Date="2024-10-09",
                            Title="[微軟授權宣導]Xmind 品牌軟體授權須知",
                            Name="許琮琪"
                        }
                    }
                },
                new Announcement
                {
                    AnnouncementCategory="內部推薦",
                    Contents=null
                },
                new Announcement
                {
                    AnnouncementCategory="BU1宣導",
                    Contents=null
                }
                };
            
            //JsonConvert.SerializeObject是用來將c#物件轉換為json字串
            //其中方法中第一個參數是放要序列化的物件
            //第二個參數( Formatting.Indented)是以縮排格式顯示 JSON，便於閱讀。
            //另外只要類別內屬性存許修飾詞設為公開他都會序列化，除非加上[JsonIgnore]他就會忽略此屬性
            string Json = JsonConvert.SerializeObject(AnnouncementInformation, Formatting.Indented);           
            Console.WriteLine(Json);
            var VacationInformation = new Vacation
            {
                Name = "趙育誠",
                TotalHours = 12,
                NoSelect = 12,
                IsSelect = 0,
                TakeRest = 0,
                Remaining="100"
            };
            string JsonVacationInfo = JsonConvert.SerializeObject(VacationInformation, Formatting.Indented);
            Console.WriteLine(JsonVacationInfo);
            var CheckInInformation = new CheckIn
            {
                TodayCheckIn = "[08:30~08:30]",
                LastLogin = "【172.16.12.153/2024-11-04 14:16:17】"
            };
            string JsonCheckInInformation = JsonConvert.SerializeObject(CheckInInformation, Formatting.Indented);
            Console.WriteLine(JsonCheckInInformation);
        }
    }
}
