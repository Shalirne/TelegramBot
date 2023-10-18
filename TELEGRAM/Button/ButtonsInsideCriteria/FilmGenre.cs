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
    internal class FilmGenre
    {
        public async static Task Genre(ITelegramBotClient BotClient, Update update, CancellationToken token, BUTTON button)
        {
            var message = update.Message;
            switch (message.Text)
            {
                case "Ужасы":
                    button.Horror = "Ужасы✅";

                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали жанр Ужасы", replyMarkup: button.KeyboardGenre());
                    break;
                case "Ужасы✅":
                    button.Horror = "Ужасы";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор жанра Ужасы", replyMarkup: button.KeyboardGenre());
                    break;

                case "Боевики":
                    button.Action = "Боевики✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали жанр Боевики", replyMarkup: button.KeyboardGenre());
                    break;
                case "Боевики✅":
                    button.Action = "Боевики";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор жанра Боевики", replyMarkup: button.KeyboardGenre());
                    break;
                case "Мелодрамы":
                    button.Melodramas = "Мелодрамы✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали жанр Мелодрамы", replyMarkup: button.KeyboardGenre());
                    break;
                case "Мелодрамы✅":
                    button.Melodramas = "Мелодрамы";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор жанра Мелодрамы", replyMarkup: button.KeyboardGenre());
                    break;

                case "Комедии":
                    button.Comedy = "Комедии✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали жанр Комедии", replyMarkup: button.KeyboardGenre());
                    break;
                case "Комедии✅":
                    button.Comedy = "Комедии";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор жанра Комедии", replyMarkup: button.KeyboardGenre());
                    break;
                case "Триллеры":
                    button.Thrillers = "Триллеры✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали жанр Триллеры", replyMarkup: button.KeyboardGenre());
                    break;
                case "Триллеры✅":
                    button.Thrillers = "Триллеры";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор жанра Триллеры", replyMarkup: button.KeyboardGenre());
                    break;
                case "Детективы":
                    button.Detectives = "Детективы✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали жанр Детективы", replyMarkup: button.KeyboardGenre());
                    break;
                case "Детективы✅":
                    button.Detectives = "Детективы";

                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор жанра Детективы", replyMarkup: button.KeyboardGenre());
                    break;
                case "Фэнтези":
                    button.Fantasy = "Фэнтези✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали жанр Фэнтези", replyMarkup: button.KeyboardGenre());
                    break;
                case "Фэнтези✅":
                    button.Fantasy = "Фэнтези";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор жанра Фэнтези", replyMarkup: button.KeyboardGenre());
                    break;
                case "Старт":
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Выберите критерии для отбора фильма", replyMarkup: button.KeyboardMenu());
                    break;
                case "Закончить с отбором ✔️":
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Выберите критерии для отбора фильма", replyMarkup: button.KeyboardMenu());
                    break;
                default:
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Я тебя не понимаю...");
                    break;
            }

        }
    }
}