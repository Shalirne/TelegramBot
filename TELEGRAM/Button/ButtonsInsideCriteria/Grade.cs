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

namespace DataBase.Button.ButtonsInsideCriteria
{
    internal class GradeTest
    {
        public async static Task Grade(ITelegramBotClient BotClient, Update update, CancellationToken token, BUTTON button)
        {
            var message = update.Message;
            switch (message.Text)
            {
                case "3-5":
                    button.ThreeFive = "3-5✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали оценку 3-5", replyMarkup: button.KeyboardGrade());
                    break;
                case "3-5✅":
                    button.ThreeFive = "3-5";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили оценку 3-5", replyMarkup: button.KeyboardGrade());
                    break;
                case "5-7":
                    button.FiveSeven = "5-7✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали оценку 5-7", replyMarkup: button.KeyboardGrade());
                    break;
                case "5-7✅":
                    button.FiveSeven = "5-7";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили оценку 5-7", replyMarkup: button.KeyboardGrade());
                    break;
                case "7<":
                    button.MoreThenSeven = "7<✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали оценки более 7", replyMarkup: button.KeyboardGrade());
                    break;
                case "7<✅":
                    button.MoreThenSeven = "7<";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили оценки более 7", replyMarkup: button.KeyboardGrade());
                    break;
            }
        }
    }
}

