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
using DataBase.Button.ButtonsInsideCriteria;
using DataBase.Dapper;

namespace DataBase.Button
{
    internal class SelectionProcessing
    {
        public static string[]? Year = { "2000 - 2010", "2010 - 2020", "2020 <", "2000 - 2010✅", "2010 - 2020✅", "2020 <✅", "2020 <" };
        public static string[]? Genre = { "Ужасы", "Боевики", "Мелодрамы", "Комедии", "Триллеры", "Детективы", "Фэнтези", "Ужасы✅", "Боевики✅", "Мелодрамы✅", "Комедии✅", "Триллеры✅", "Детективы✅", "Фэнтези✅" };
        public static string[]? Grade = { "3-5", "5-7", "7<", "3-5✅", "5-7✅", "7<✅" };
        public static string[]? Actors = { "Киану Ривз", "Том Круз", "Леонардо Ди Каприо", "Брэд Питт", "Роберт Дауни мл.", "Дэниел Крейг", "Дуэйн Джонсон",
            "Киану Ривз✅", "Том Круз✅", "Леонардо Ди Каприо✅", "Брэд Питт✅", "Роберт Дауни мл.✅", "Дэниел Крейг✅", "Дуэйн Джонсон✅" };
        public static string[]? ChoiceByFilm = { "Предыдущий фильм", "Далее", "Добавить в избранное", "Выйти" };
        public static string[]? ChoiceBySelectedMovies = { "Предыдущий избранный фильм", "Далее из избранных фильмов", "Выйти из избранных фильмов" };
        public async static Task WhereToSendMessage(ITelegramBotClient BotClient, Update update, CancellationToken token, BUTTON button)
        {
            var message = update.Message.Text;
            if (Year.Contains(message))
            {
                await FileYears.Genre(BotClient, update, token, button);
            }
            if (Genre.Contains(message))
            {
                await FilmGenre.Genre(BotClient, update, token, button);
            }
            if (Grade.Contains(message))
            {
                await GradeTest.Grade(BotClient, update, token, button);
            }
            if (Actors.Contains(message))
            {
                await FilmActor.Actor(BotClient, update, token, button);
            }
            if (ChoiceByFilm.Contains(message))
            {
                await Dapper1.MovieSelection(BotClient, update, token, button);
            }
            if (ChoiceBySelectedMovies.Contains(message))
            {
                await Dapper1.ShowFeaturedMovies(BotClient, update, token, button);
            }
        }
    }
}

