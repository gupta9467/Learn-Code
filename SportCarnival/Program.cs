using Newtonsoft.Json;
using SportCarnival.Enums;
using SportCarnival.Model;
using SportCarnival.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCarnival
{
    public class Program
    {
        public static int total = 0;

        public static void Main(string[] args)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(@"D:\Learn&CodeGraduation\Learn-Code\SportCarnival\SampleJson\TeamInput.json"));

            TeamMethod teamMethod = new TeamMethod();
            if (game.Players.Count > 0)
            {
                switch (game.GameType)
                {
                    case GameType.Cricket:
                        if (game.Players.Count % AppConstant.Constant.CricketPlayers == 0)
                        {
                            List<Team> teams = teamMethod.CreateTeam(game);
                            foreach (Team team in teams)
                            {
                                Console.WriteLine(JsonConvert.SerializeObject(team));
                                total++;
                            }
                            Console.WriteLine(total);
                        }
                        else
                        {
                            Console.WriteLine("Player is Less we can't create a Team");
                        }
                        break;

                    case GameType.Badminton:
                        if (game.Players.Count % AppConstant.Constant.BedMintonPlayers == 0)
                        {
                            List<Team> teams = teamMethod.CreateTeam(game);
                            foreach (Team team in teams)
                            {
                                Console.WriteLine(JsonConvert.SerializeObject(team));
                                total++;
                            }
                            Console.WriteLine(total);
                        }
                        break;

                    case GameType.Chess:
                        if (game.Players.Count % AppConstant.Constant.ChessPlayer == 0)
                        {
                            List<Team> teams = teamMethod.CreateTeam(game);
                            foreach (Team team in teams)
                            {
                                Console.WriteLine(JsonConvert.SerializeObject(team));
                                total++;
                            }
                            Console.WriteLine(total);
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

            Console.ReadLine();
        }
    }
}