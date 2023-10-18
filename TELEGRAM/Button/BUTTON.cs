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

namespace DataBase.Button
{
    public class BUTTON
    {
        public string Horror { get; set; } = "Ужасы";
        public string Action { get; set; } = "Боевики";
        public string Melodramas { get; set; } = "Мелодрамы";
        public string Comedy { get; set; } = "Комедии";
        public string Thrillers { get; set; } = "Триллеры";
        public string Detectives { get; set; } = "Детективы";
        public string Fantasy { get; set; } = "Фэнтези";
        public string Years2000_2010 { get; set; } = "2000 - 2010";
        public string Years2010_2020 { get; set; } = "2010 - 2020";
        public string Years2020 { get; set; } = "2020 <";
        public string ThreeFive { get; set; } = "3-5";
        public string FiveSeven { get; set; } = "5-7";
        public string MoreThenSeven { get; set; } = "7<";
        public string KeanuReeves { get; set; } = "Киану Ривз";
        public string TomCruise { get; set; } = "Том Круз";
        public string LeonardoDiCaprio { get; set; } = "Леонардо Ди Каприо";
        public string BradPitt { get; set; } = "Брэд Питт";
        public string RobertDowney { get; set; } = "Роберт Дауни мл.";
        public string DanielCraig { get; set; } = "Дэниел Крейг";
        public string DwayneJohnson { get; set; } = "Дуэйн Джонсон";

        public ReplyKeyboardMarkup KeyboardMenu()
        {
            var keyboardMenu = new ReplyKeyboardMarkup(new[]
            {
            new[]
            {
                new KeyboardButton("Жанр"),
            },
                        new[]
            {
                new KeyboardButton("Год"),
            },
                                    new[]
            {
                new KeyboardButton("Актеры"),
            },
                                                new[]
            {
                new KeyboardButton("Оценка"),
            },
                                                       new[]
            {
                new KeyboardButton("Приступить к поиску")
            },
                                                            new[]
            {
                new KeyboardButton("Очистить переписку")
            },
                                                                                                                        new[]
            {
                new KeyboardButton("Показать избранное")
            }
        }
            );
            return keyboardMenu;
        }
        public ReplyKeyboardMarkup KeyboardGenre()
        {
            ReplyKeyboardMarkup keyboardGenre = new ReplyKeyboardMarkup(new[]
            {
            new[]
            {
                new KeyboardButton(Horror),
            },
            new[]
            {
                new KeyboardButton(Action), // 5
            },
            new[]
            {
                new KeyboardButton(Melodramas), // 1
            },
            new[]
            {
                new KeyboardButton(Comedy), // 1
            },
            new[]
            {
                new KeyboardButton(Thrillers), // 4
            },
            new[]
            {
                new KeyboardButton(Detectives), // 2
            },
            new[]
            {
                new KeyboardButton(Fantasy), // 1
            },
            new[]
            {
                new KeyboardButton("Закончить с отбором ✔️"),
            }

            }
    );
            return keyboardGenre;
        }

        public ReplyKeyboardMarkup KeyboardYears()
        {
            ReplyKeyboardMarkup keyboardYears = new ReplyKeyboardMarkup(new[]
        {
            new[]
            {
                new KeyboardButton(Years2000_2010),
            },
            new[]
            {
                new KeyboardButton(Years2010_2020),
            },
            new[]
            {
                new KeyboardButton(Years2020),
            },
            new[]
            {
                new KeyboardButton("Закончить с отбором ✔️"),
            }
            }
        );
            return keyboardYears;
        }
        public ReplyKeyboardMarkup KeyboardGrade()
        {
            ReplyKeyboardMarkup keyboardGrade = new ReplyKeyboardMarkup(new[]
       {
            new[]
            {
                new KeyboardButton(ThreeFive),
            },
            new[]
            {
                new KeyboardButton(FiveSeven),
            },
            new[]
            {
                new KeyboardButton(MoreThenSeven),
            },
            new[]
            {
                new KeyboardButton("Закончить с отбором ✔️"),
            }
            }

       );
            return keyboardGrade;
        }

        public ReplyKeyboardMarkup KeyboardActor()
        {
            ReplyKeyboardMarkup keyboardActor = new ReplyKeyboardMarkup(new[]
       {
            new[]
            {
                new KeyboardButton(KeanuReeves), // - 
            },
            new[]
            {
                new KeyboardButton(TomCruise), // -
            },
            new[]
            {
                new KeyboardButton(LeonardoDiCaprio), // -- 
            },
            new[]
            {
                new KeyboardButton(BradPitt),
            },
            new[]
            {
                new KeyboardButton(RobertDowney),
            },
            new[]
            {
                new KeyboardButton(DanielCraig),
            },
            new[]
            {
                new KeyboardButton(DwayneJohnson),
            },

            new[]
            {
                new KeyboardButton("Закончить с отбором ✔️"),
            }
            }

       );
            return keyboardActor;
        }

        public ReplyKeyboardMarkup PickAMovie()
        {
            ReplyKeyboardMarkup keyboardGrade = new ReplyKeyboardMarkup(new[]
       {
            new[]
            {
                new KeyboardButton("Предыдущий фильм"),
            },
            new[]
            {
                new KeyboardButton("Далее"),
            },
            new[]
            {
                new KeyboardButton("Добавить в избранное"),
            },
            new[]
            {
                new KeyboardButton("Выйти"),
            }
            }

       );
            return keyboardGrade;
        }

        public ReplyKeyboardMarkup SelectFavoriteMovies()
        {
            ReplyKeyboardMarkup keyboardGrade = new ReplyKeyboardMarkup(new[]
       {
            new[]
            {
                new KeyboardButton("Предыдущий избранный фильм"),
            },
            new[]
            {
                new KeyboardButton("Далее из избранных фильмов"),
            },
            new[]
            {
                new KeyboardButton("Выйти из избранных фильмов"),
            }
            }

       );
            return keyboardGrade;
        }
    }
}

//var inlineKeyboard = new InlineKeyboardMarkup(new[]  // это для кнопок в чате
//    {
//        // first row
//        new []
//        {
//            InlineKeyboardButton.WithCallbackData("Написать нам в телеграмм", "callback1"),
//            InlineKeyboardButton.WithCallbackData("Наши контакты", "callback2"),
//        },
//        // second row
//        new []
//        {
//            InlineKeyboardButton.WithCallbackData("Наши услуги", "callback3"),
//            InlineKeyboardButton.WithCallbackData("О нас", "callback4"),
//        }
//    });
//await BotClient.SendTextMessageAsync(message.Chat.Id, "Нажмите на кнопку:", replyMarkup: inlineKeyboard);using System;