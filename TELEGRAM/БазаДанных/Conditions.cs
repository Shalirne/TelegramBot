using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using DataBase.Button;

namespace DataBase.БазаДанных
{
    internal class Вставка_условий
    {
        public static string ПостроениеУсловий(ITelegramBotClient BotClient, Update update, CancellationToken token)
        {
            string FinalRequest = "";
            string RequestYears = "";
            string RequestGenres = "";
            string RequestRatings = "";
            string RequestActors = "";
            List<BUTTON> buttons = new List<BUTTON>();
            foreach (var c in MessageProcessing.KeyboardStatus)
            {
                if (c.Key == update.Message.Chat.Id)
                {
                    buttons.Add(c.Value.Keyboard);
                }
            }
            foreach (var c in buttons)
            {
                if (c.Years2000_2010.Contains("✅"))
                {
                    RequestYears = "2000 < years AND years < 2010";
                }


                if (c.Years2010_2020.Contains("✅"))
                {
                    if (c.Years2000_2010.Contains("✅"))
                    {
                        RequestYears = RequestYears + " " + "OR 2010 < years AND years < 2020";
                    }
                    else
                    {
                        RequestYears = "2010 < years AND years < 2020";
                    }
                }


                if (c.Years2020.Contains("✅"))
                {
                    if (c.Years2000_2010.Contains("✅") || c.Years2010_2020.Contains("✅"))
                    {
                        RequestYears = RequestYears + " " + "OR 2020 < years";
                    }
                    else
                    {
                        RequestYears = "2020 < years";
                    }
                }

                //-------------------------------------------------------------------------------------------------------------



                if (c.Action.Contains("✅"))
                {
                    RequestGenres = "genre LIKE '%Боевик%'";
                }


                if (c.Detectives.Contains("✅"))
                {
                    if (c.Action.Contains("✅"))
                    {
                        RequestGenres = RequestGenres + " " + "OR genre LIKE '%Детектик%'";
                    }
                    else
                    {
                        RequestGenres = "genre LIKE '%Детектик%'";
                    }
                }

                if (c.Comedy.Contains("✅"))
                {
                    if (c.Action.Contains("✅") || c.Detectives.Contains("✅"))
                    {
                        RequestGenres = RequestGenres + " " + "OR genre LIKE '%Комедия%'";
                    }
                    else
                    {
                        RequestGenres = "genre LIKE '%Комедия%'";
                    }

                }


                if (c.Melodramas.Contains("✅"))
                {
                    if (c.Action.Contains("✅") || c.Detectives.Contains("✅") || c.Comedy.Contains("✅"))
                    {
                        RequestGenres = RequestGenres + " " + "OR genre LIKE '%Мелодрама%'";
                    }
                    else
                    {
                        RequestGenres = "genre LIKE '%Мелодрама%'";
                    }
                }


                if (c.Thrillers.Contains("✅"))
                {
                    if (c.Action.Contains("✅") || c.Detectives.Contains("✅") || c.Comedy.Contains("✅") || c.Melodramas.Contains("✅"))
                    {
                        RequestGenres = RequestGenres + " " + "OR genre LIKE '%Триллер%'";
                    }
                    else
                    {
                        RequestGenres = "genre LIKE '%Триллер%'";
                    }

                }


                if (c.Horror.Contains("✅"))
                {
                    if (c.Action.Contains("✅") || c.Detectives.Contains("✅") || c.Comedy.Contains("✅") || c.Melodramas.Contains("✅") || c.Thrillers.Contains("✅"))
                    {
                        RequestGenres = RequestGenres + " " + "OR genre LIKE '%Ужасы%'";
                    }
                    else
                    {
                        RequestGenres = "genre LIKE '%Ужасы%'";
                    }

                }


                if (c.Fantasy.Contains("✅"))
                {
                    if (c.Action.Contains("✅") || c.Detectives.Contains("✅") || c.Comedy.Contains("✅") || c.Melodramas.Contains("✅") || c.Thrillers.Contains("✅") || c.Horror.Contains("✅"))
                    {
                        RequestGenres = RequestGenres + " " + "OR genre LIKE '%Фэнтези%'";
                    }
                    else
                    {
                        RequestGenres = "genre LIKE '%Фэнтези%'";
                    }

                }

                //----------------------------------------------------------------------------------------------------------------------------------------------------------------

                if (c.ThreeFive.Contains("✅"))
                {
                    RequestRatings = "3 < grade AND grade < 5";
                }


                if (c.FiveSeven.Contains("✅"))
                {
                    if (c.ThreeFive.Contains("✅"))
                    {
                        RequestRatings = RequestRatings + " " + "OR 5 < grade AND grade < 7";
                    }
                    else
                    {
                        RequestRatings = "5 < grade AND grade < 7";
                    }
                }


                if (c.MoreThenSeven.Contains("✅"))
                {
                    if (c.ThreeFive.Contains("✅") || c.ThreeFive.Contains("✅"))
                    {
                        RequestRatings = RequestRatings + " " + "OR 7 < grade";
                    }
                    else
                    {
                        RequestRatings = "7 < grade";
                    }
                }
                // _____________________________________________________________________________________________________________________________________________________________________

                if (c.BradPitt.Contains("✅"))
                {
                    RequestActors = "actor_firstname = Брэд";
                }
                if (c.DwayneJohnson.Contains("✅"))
                {
                    if (c.BradPitt.Contains("✅"))
                    {
                        RequestActors = RequestActors + " " + "OR actor_firstname = Дуэйн";
                    }
                    else
                    {
                        RequestActors = "actor_firstname = Дуэйн";
                    }
                }
                if (c.DanielCraig.Contains("✅"))
                {
                    if (c.BradPitt.Contains("✅") || c.DwayneJohnson.Contains("✅"))
                    {
                        RequestActors = RequestActors + " " + "OR actor_firstname = Дэниел";
                    }    
                    else
                    {
                        RequestActors = "actor_firstname = Дэниел";
                    }
                }
                if (c.KeanuReeves.Contains("✅"))
                {
                    if (c.BradPitt.Contains("✅") || c.DwayneJohnson.Contains("✅") || c.DanielCraig.Contains("✅"))
                    {
                        RequestActors = RequestActors + " " + "OR actor_firstname = Киану";
                    }    
                    else
                    {
                        RequestActors = "actor_firstname = Киану";
                    }
                }
                if (c.LeonardoDiCaprio.Contains("✅"))
                {
                    if (c.BradPitt.Contains("✅") || c.DwayneJohnson.Contains("✅") || c.DanielCraig.Contains("✅") || c.KeanuReeves.Contains("✅"))
                    {
                        RequestActors = RequestActors + " " + "OR actor_firstname = Леонардо";
                    } 
                    else
                    {
                        RequestActors = "actor_firstname = Леонардо";
                    }
                }
                if (c.RobertDowney.Contains("✅"))
                {
                    if (c.BradPitt.Contains("✅") || c.DwayneJohnson.Contains("✅") || c.DanielCraig.Contains("✅") || c.KeanuReeves.Contains("✅") || c.LeonardoDiCaprio.Contains("✅"))
                    {
                        RequestActors = RequestActors + " " + "OR actor_firstname = Роберт";
                    }    
                    else
                    {
                        RequestActors = "actor_firstname = Робер Дауни";
                    }
                }
                if (c.TomCruise.Contains("✅"))
                {
                    if (c.BradPitt.Contains("✅") || c.DwayneJohnson.Contains("✅") || c.DanielCraig.Contains("✅") || c.KeanuReeves.Contains("✅") || c.LeonardoDiCaprio.Contains("✅") || c.RobertDowney.Contains("✅"))
                    {
                        RequestActors = RequestActors + " " + "OR actor_firstname = Том";
                    }    
                    else
                    {
                        RequestActors = "actor_firstname = Том";
                    }
                }

                // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------
                if (RequestYears.Length > 3)
                {
                    FinalRequest = RequestYears;
                }
                if (RequestGenres.Length > 3)
                {
                    if (RequestYears.Length > 3)
                    {
                        FinalRequest = FinalRequest + " AND " + RequestGenres;
                    }
                    else
                    {
                        FinalRequest = RequestGenres;
                    }
                }
                if (RequestRatings.Length > 3)
                {
                    if (RequestGenres.Length > 3 || RequestYears.Length > 3)
                    {
                        FinalRequest = FinalRequest + " AND " + RequestRatings;
                    }
                    else
                    {
                        FinalRequest = RequestRatings;
                    }
                }
                if (RequestActors.Length > 3)
                {
                    if (RequestGenres.Length > 3 || RequestYears.Length > 3 || RequestRatings.Length > 3)
                    {
                        FinalRequest = FinalRequest + " AND " + RequestActors;
                    }
                    else
                    {
                        FinalRequest = RequestActors;
                    }
                }
            }
            return FinalRequest;
        }
    }
}
