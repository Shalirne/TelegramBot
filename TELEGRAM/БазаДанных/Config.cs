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
    public static class Config
    {
        public static string SqlConnectionString = "User ID= postgres;Password=R3R85kN4;Host=localhost;Port=5432;Database=Film;";
    }
}
