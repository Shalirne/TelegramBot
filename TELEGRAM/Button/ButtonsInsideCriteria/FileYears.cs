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
    internal class FileYears
    {
        public async static Task Genre(ITelegramBotClient BotClient, Update update, CancellationToken token, BUTTON button)
        {
            var message = update.Message;
            switch (message.Text)
            {
                case "2000 - 2010":
                    button.Years2000_2010 = "2000 - 2010✅";

                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали года 2000 - 2010", replyMarkup: button.KeyboardYears());
                    break;
                case "2000 - 2010✅":
                    button.Years2000_2010 = "2000 - 2010";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор годов 2000 - 2010", replyMarkup: button.KeyboardYears());
                    break;

                case "2010 - 2020":
                    button.Years2010_2020 = "2010 - 2020✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали года 2010 - 2020", replyMarkup: button.KeyboardYears());
                    break;
                case "2010 - 2020✅":
                    button.Years2010_2020 = "2010 - 2020";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор годов 2010 - 2020", replyMarkup: button.KeyboardYears());
                    break;
                case "2020 <":
                    button.Years2020 = "2020 <✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали года после 2020", replyMarkup: button.KeyboardYears());
                    break;
                case "2020 <✅":
                    button.Years2020 = "2020 <";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор годов после 2020", replyMarkup: button.KeyboardYears());
                    break;
            }
        }
    }
}

