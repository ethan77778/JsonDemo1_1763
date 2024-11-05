using Newtonsoft.Json;

namespace JsonDemo1_1763
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var All = new AllType
            {
                Announcements=new List<Announcement>
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
                        Contents=null,
                    }
                },
                VacationInfo=new Vacation
                {
                   Name="趙育誠",
                    TotalHours = 12,
                    NoSelect = 12,
                    IsSelect = 0,
                    TakeRest = 0,
                    Remaining = "100"
                },
                CheckInfo=new CheckIn
                {
                    TodayCheckIn = "[08:30~08:30]",
                    LastLogin = "【172.16.12.153/2024-11-04 14:16:17】"
                }
            };
            string Json = JsonConvert.SerializeObject(All, Formatting.Indented);
            Console.WriteLine(Json);
        }
    }
}
