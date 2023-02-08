using Newtonsoft.Json;
using SportCarnival.Enums;
using SportCarnival.Model;
using SportCarnival.RepositoryData;
using SportCarnival.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCarnival
{
    public class helper
    {
        public static int total = 0;
        private TeamMethod teamMethod = new TeamMethod();

        public List<Team> GetTeam(int gameId, int eventId)
        {
            return teamMethod.GetTeams(gameId, eventId);
        }

        public void CreateTeam(Game game)
        {
            PlayerService playerService = new PlayerService();
            playerService.AddPlayer(game);

            if (game.Players.Count > 0)
            {
                switch (game.GameType)
                {
                    case GameTypes.Cricket:
                        if (game.Players.Count % AppConstant.Constant.CricketPlayers == 0)
                        {
                            teamMethod.CreateTeam(game);
                            Console.WriteLine("Team Created");
                        }
                        else
                        {
                            Console.WriteLine("Player is Less we can't create a Team");
                        }
                        break;

                    case GameTypes.Badminton:
                        if (game.Players.Count % AppConstant.Constant.BedMintonPlayers == 0)
                        {
                            teamMethod.CreateTeam(game);
                            Console.WriteLine("Team Created");
                        }
                        else
                        {
                            Console.WriteLine("Player is Less we can't create a Team");
                        }

                        break;

                    case GameTypes.Chess:
                        if (game.Players.Count % AppConstant.Constant.ChessPlayer == 0)
                        {
                            teamMethod.CreateTeam(game);
                            Console.WriteLine("Team Created");
                        }
                        else
                        {
                            Console.WriteLine("Player is Less we can't create a Team");
                        }
                        break;

                    default:
                        Console.WriteLine("Player is Less we can't create a Team");
                        break;
                }
            }
            else
            {
                Console.WriteLine("No Player we can't create a Team");
            }
        }
    }
}