using System;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Npgsql;
using Telegram.Bot.Types;
using Telegram.Bot;
using DataBase.Button;
using System.Collections.Concurrent;
using Telegram.Bot.Types.ReplyMarkups;
namespace DataBase.БазаДанных
{
    public class Movies
    {
        public string Title { get; set; }
        public string Grade { get; set; }
        public string Actor_FirstName{ get; set; }
        public string Actor_LastName { get; set; }
        public string Genre { get; set; }
        public string Years { get; set; }
        public string Picture { get; set; }
    }

}
