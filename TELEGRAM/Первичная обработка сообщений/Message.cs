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
using DataBase.БазаДанных;
using DataBase.Dapper;

namespace DataBase
{
    internal class MessageProcessing
    {
        public static ConcurrentDictionary<long,User> KeyboardStatus = new ConcurrentDictionary<long, User>();
        
        public async static Task PersonallyForTheUser(ITelegramBotClient BotClient, Update update, CancellationToken token)
        {
            BUTTON button = new BUTTON();

            if (KeyboardStatus.Keys.Contains(update.Message.Chat.Id))
            {
                foreach (var c in KeyboardStatus)
                {
                    if (c.Key == update.Message.Chat.Id)
                    {
                        button = c.Value.Keyboard;
                        break;
                    }
                }
            }
            else
            {
                KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldvalue) => oldvalue);
                button = KeyboardStatus[update.Message.Chat.Id].Keyboard;
            }
            var message = update.Message;
            if (message.Text != null)
            {
                Console.WriteLine($"Вам пишет {message.Chat.Username}, текст сообщения - {message.Text}");
                switch (message.Text)
                {
                    case "Жанр":
                        await BotClient.SendTextMessageAsync(message.Chat.Id, "Какой жанр Вас интересует?", replyMarkup: button.KeyboardGenre());
                        break;

                    case "Год":
                        await BotClient.SendTextMessageAsync(message.Chat.Id, "Какие года Вас интересуют?", replyMarkup: button.KeyboardYears());
                        break;

                    case "Оценка":
                        await BotClient.SendTextMessageAsync(message.Chat.Id, "Какие критерии для оценки Вас интересуют?", replyMarkup: button.KeyboardGrade());
                        break;

                    case "Актеры":
                        await BotClient.SendTextMessageAsync(message.Chat.Id, "Какие критерии для оценки Вас интересуют?", replyMarkup: button.KeyboardActor());
                        break;

                    case "Закончить с отбором ✔️":
                        await BotClient.SendTextMessageAsync(message.Chat.Id, "Выберите критерии для отбора фильма", replyMarkup: button.KeyboardMenu());
                        break;

                    case "привет":
                        await BotClient.SendTextMessageAsync(message.Chat.Id, "https://stsci-opo.org/STScI-01H530DYPSS3D50JQ0R7E152CM.png");
                        break;
                    case "Старт":
                        await BotClient.SendTextMessageAsync(message.Chat.Id, "Выберите критерии для отбора фильма", replyMarkup: button.KeyboardMenu());
                        break;
                    case "Приступить к поиску":
                        await Dapper1.GetInformationAboutTheMovie(BotClient, update, token);
                        break;
                    case "Показать избранное":
                        await Dapper1.ShowFeaturedMovies(BotClient, update, token, button);
                        break;
                    default:
                        await SelectionProcessing.WhereToSendMessage(BotClient, update, token, button);
                        break;

                }
            }
        }
    }
}

