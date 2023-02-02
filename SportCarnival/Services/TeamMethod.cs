using SportCarnival.Enums;
using SportCarnival.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCarnival.Services
{
    public class TeamMethod
    {
        public static int numberofPlayer;
        public static string teamName = "Team - ";

        public List<Team> CreateTeam(Game game)

        {
            List<Team> teams = new List<Team>();
            if (game.GameType == GameType.Cricket)
            {
                int numberofPlayers = AppConstant.Constant.CricketPlayers;
                List<Team> team = CreateTeamForGame(game.Players, game.GameType, numberofPlayers);
                teams.AddRange(team);
            }
            else if (game.GameType == GameType.Badminton)
            {
                int numberofPlayers = AppConstant.Constant.BedMintonPlayers;
                List<Team> team = CreateTeamForGame(game.Players, game.GameType, numberofPlayers);
                teams.AddRange(team);
            }
            else if (game.GameType == GameType.Chess)
            {
                int numberofPlayers = AppConstant.Constant.ChessPlayer;
                List<Team> team = CreateTeamForGame(game.Players, game.GameType, numberofPlayers);
                teams.AddRange(team);
            }
            return teams;
        }

        public static List<Team> CreateTeamForGame(List<Player> players, GameType gameType, int numberofPlayers)
        {
            List<Team> teams = new List<Team>();
            int teamId = 1;
            char alphabetTeam = 'A';
            if (players.Count < numberofPlayers)
            {
                return teams;
            }

            List<Player> teamPlayer = new List<Player>();

            foreach (Player player in players)
            {
                teamPlayer.Add(player);
                if (teamPlayer.Count % numberofPlayers == 0)
                {
                    Team team = new Team()
                    {
                        TeamId = teamId,
                        TeamName = teamName + alphabetTeam,
                        GameType = gameType,
                        Players = teamPlayer
                    };
                    teams.Add(team);
                    teamId++;
                    alphabetTeam++;
                    teamPlayer = new List<Player>();
                }
            }

            return teams;
        }
    }
}