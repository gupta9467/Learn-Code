using Newtonsoft.Json;
using SportCarnival.Enums;
using SportCarnival.Model;
using SportCarnival.RepositoryData;
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
        public static int eventId = 1;

        public static void Main(string[] args)
        {
            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(@"D:\CodeGraduation\Learn-Code\SportCarnival\SampleJson\TeamInput.json"));

            Console.WriteLine("1. Add Team \n");
            Console.WriteLine("2. Get Team \n");
            Console.WriteLine("Enter the action you want to perform: ");
            int choice = Int32.Parse(Console.ReadLine());
            helper hp = new helper();
            switch (choice)
            {
                case 1:
                    hp.CreateTeam(game);
                    break;

                case 2:
                    List<Team> teams = hp.GetTeam((int)game.GameType, eventId);
                    Console.WriteLine("total : " + teams.Count);
                    foreach (Team team in teams)
                    {
                        Console.WriteLine("TeamId :" + team.teamId + ", TeamName :" + team.name + ",GameId " + team.gameId);
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}