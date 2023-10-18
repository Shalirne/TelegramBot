using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace DataBase.Button.ButtonsInsideCriteria
{
    internal class FilmActor
    {
        public async static Task Actor(ITelegramBotClient BotClient, Update update, CancellationToken token, BUTTON button)
        {
            var message = update.Message;
            switch (message.Text)
            {
                case "Киану Ривз":
                    button.KeanuReeves = "Киану Ривз✅";

                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали актера Киану Ривз", replyMarkup: button.KeyboardActor());
                    break;
                case "Киану Ривз✅":
                    button.KeanuReeves = "Киану Ривз";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор актера Киану Ривз", replyMarkup: button.KeyboardActor());
                    break;
                case "Том Круз":
                    button.TomCruise = "Том Круз✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали актера Том Круз", replyMarkup: button.KeyboardActor());
                    break;
                case "Том Круз✅":
                    button.TomCruise = "Том Круз";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор актера Том Круз", replyMarkup: button.KeyboardActor());
                    break;
                case "Леонардо Ди Каприо":
                    button.LeonardoDiCaprio = "Леонардо Ди Каприо✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали актера Леонардо Ди Каприо", replyMarkup: button.KeyboardActor());
                    break;
                case "Леонардо Ди Каприо✅":
                    button.LeonardoDiCaprio = "Леонардо Ди Каприо";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор актера Леонардо Ди Каприо", replyMarkup: button.KeyboardActor());
                    break;
                case "Брэд Питт":
                    button.BradPitt = "Брэд Питт✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали актера Брэд Питт", replyMarkup: button.KeyboardActor());
                    break;
                case "Брэд Питт✅":
                    button.BradPitt = "Брэд Питт";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор актера Брэд Питт", replyMarkup: button.KeyboardActor());
                    break;
                case "Роберт Дауни мл.":
                    button.RobertDowney = "Роберт Дауни мл.✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали актера Роберт Дауни мл.", replyMarkup: button.KeyboardActor());
                    break;
                case "Роберт Дауни мл.✅":
                    button.RobertDowney = "Роберт Дауни мл.";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор актера Роберт Дауни мл.", replyMarkup: button.KeyboardActor());
                    break;
                case "Дэниел Крейг":
                    button.DanielCraig = "Дэниел Крейг✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали актера Дэниел Крейг", replyMarkup: button.KeyboardActor());
                    break;

                case "Дэниел Крейг✅":
                    button.DanielCraig = "Дэниел Крейг";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор актера Дэниел Крейг", replyMarkup: button.KeyboardActor());
                    break;
                case "Дуэйн Джонсон":
                    button.DwayneJohnson = "Дуэйн Джонсон✅";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы выбрали актера Дуэйн Джонсон", replyMarkup: button.KeyboardActor());
                    break;
                case "Дуэйн Джонсон✅":
                    button.DwayneJohnson = "Дуэйн Джонсон";
                    foreach (var c in MessageProcessing.KeyboardStatus)
                    {
                        if (c.Key == update.Message.Chat.Id)
                        {
                            MessageProcessing.KeyboardStatus.AddOrUpdate(update.Message.Chat.Id, new User { Keyboard = new BUTTON(), ID = update.Message.Chat.Id }, (key, oldValue) => new User { Keyboard = button, ID = update.Message.Chat.Id });
                            break;
                        }
                    }
                    await BotClient.SendTextMessageAsync(message.Chat.Id, "Вы отменили выбор актера Дуэйн Джонсон", replyMarkup: button.KeyboardActor());
                    break;
            }
        }
    }
}
