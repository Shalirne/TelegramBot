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

namespace DataBase
{
    internal class Program
    {
        public static void Main()
        {
            var bot = new TelegramBotClient("6326507138:AAHBqFfbtSSwUFHyNudKyzj_g0z85jz-o38");
            bot.StartReceiving(Update, Error);
            Console.ReadLine();
        }
        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            throw new NotImplementedException();
        }
        async static Task Update(ITelegramBotClient BotClient, Update update, CancellationToken token)
        {
            MessageProcessing.PersonallyForTheUser(BotClient, update, token);
        }
    }
}
//await BotClient.SendTextMessageAsync(     // ВОТ ТАК МЫ УДАЛЯЕМ КЛАВИАТУРУ
//chatId: message.Chat.Id,
//text: "Removing keyboard",
//replyMarkup: new ReplyKeyboardRemove(),
//cancellationToken: token);