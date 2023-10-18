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
using Telegram.Bot.Types.Enums;
using DataBase.БазаДанных;

namespace DataBase.Dapper
{
    public class Dapper1
    {
        public static List<Movies> Favorites = new List<Movies>();
        public static int MovieCounter = 0;
        public static int CounterForFavoriteMovies = 0;
        public static List<Movies> ActingFilms = new List<Movies>();
        public async static Task GetInformationAboutTheMovie(ITelegramBotClient BotClient, Update update, CancellationToken token)
        {
            BUTTON button = new BUTTON();
            var message = update.Message;
            string Request = Вставка_условий.ПостроениеУсловий(BotClient, update, token);
            var film = GetInfo(Request);
            foreach (var item in film)
            {
                ActingFilms.Add(item);
            }
            await BotClient.SendTextMessageAsync(message.Chat.Id, "Выберите интересующий Вас Фильм", replyMarkup: button.PickAMovie());
            await Print(ActingFilms[0], BotClient, update, token);
        }

        public static IEnumerable<Movies> GetInfo(string request)
        {

            using (var conn = new NpgsqlConnection(Config.SqlConnectionString))
            {
                string sql = "SELECT title, picture FROM film WHERE " + $"{request}";
                return conn.Query<Movies>(sql, new { request });
            }
        }
        public async static Task Print(Movies movies, ITelegramBotClient BotClient, Update update, CancellationToken token)
        {
            var message = update.Message;
            await BotClient.SendPhotoAsync(
      chatId: message.Chat.Id,
      photo: InputFile.FromUri($"{movies.Picture}"),
      caption: $"{movies.Title}",
      parseMode: ParseMode.Html,
      cancellationToken: token);
        }

        public async static Task MovieSelection(ITelegramBotClient BotClient, Update update, CancellationToken token, BUTTON button)
        {
            var message = update.Message;

            if (message.Text == "Предыдущий фильм")
            {
                if (MovieCounter <= ActingFilms.Count - 1)
                {
                    MovieCounter -= 1;
                }
                if (MovieCounter == ActingFilms.Count - 1)
                {
                    MovieCounter = ActingFilms.Count - 1;
                }
                if (MovieCounter < 0)
                {
                    MovieCounter = 0;
                }
                await Print(ActingFilms[MovieCounter], BotClient, update, token);
            }
            if (message.Text == "Далее")
            {
                if (MovieCounter < ActingFilms.Count - 1)
                {
                    MovieCounter += 1;
                }
                if (MovieCounter == ActingFilms.Count - 1)
                {
                    MovieCounter = ActingFilms.Count - 1;
                }
                await Print(ActingFilms[MovieCounter], BotClient, update, token);
            }
            if (message.Text == "Добавить в избранное")
            {
                Favorites.Add(ActingFilms[MovieCounter]);
            }
            if (message.Text == "Выйти")
            {
                foreach (var c in MessageProcessing.KeyboardStatus)
                {
                    if (c.Key == update.Message.Chat.Id)
                    {
                        c.Value.Keyboard = new BUTTON();
                        break;
                    }
                }
                await BotClient.SendTextMessageAsync(message.Chat.Id, "Запрос выполнен", replyMarkup: button.KeyboardMenu());
            }
            if (message.Text != "Выйти")
            {
                await BotClient.SendTextMessageAsync(message.Chat.Id, "Запрос выполнен", replyMarkup: button.PickAMovie());
            }
        }
        public async static Task ShowFeaturedMovies(ITelegramBotClient BotClient, Update update, CancellationToken token, BUTTON button)
        {
            var message = update.Message;

            if (message.Text == "Предыдущий избранный фильм")
            {
                if (CounterForFavoriteMovies <= Favorites.Count - 1)
                {
                    CounterForFavoriteMovies -= 1;
                }
                if (CounterForFavoriteMovies == Favorites.Count - 1)
                {
                    CounterForFavoriteMovies = Favorites.Count - 1;
                }
                if (CounterForFavoriteMovies < 0)
                {
                    CounterForFavoriteMovies = 0;
                }
            }
            if (message.Text == "Далее из избранных фильмов")
            {
                if (CounterForFavoriteMovies < Favorites.Count - 1)
                {
                    CounterForFavoriteMovies += 1;
                }
                if (CounterForFavoriteMovies == Favorites.Count - 1)
                {
                    CounterForFavoriteMovies = Favorites.Count - 1;
                }
            }
            if (message.Text == "Выйти из избранных фильмов")
            {
                foreach (var c in MessageProcessing.KeyboardStatus)
                {
                    if (c.Key == update.Message.Chat.Id)
                    {
                        c.Value.Keyboard = new BUTTON();
                        break;
                    }
                }
                await BotClient.SendTextMessageAsync(message.Chat.Id, "Запрос выполнен", replyMarkup: button.KeyboardMenu());
            }
            if (message.Text != "Выйти из избранных фильмов")
            {
                await BotClient.SendTextMessageAsync(message.Chat.Id, "Запрос выполнен", replyMarkup: button.SelectFavoriteMovies());
                await Print(Favorites[CounterForFavoriteMovies], BotClient, update, token);
            }
        }
    }
}
