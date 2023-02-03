using SportCarnival.Enums;
using SportCarnival.Model;
using SportCarnival.Repository;
using SportCarnival.RepositoryData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameType = SportCarnival.RepositoryData.GameType;

namespace SportCarnival.Services
{
    public class TeamMethod
    {
        public static int numberofPlayer;
        public static string teamName = "Team - ";

        private TeamRepository _teamRepository = new TeamRepository();

        public List<Teams> CreateTeam(Game game)
        {
            List<Teams> teams = new List<Teams>();
            if (game.GameType == GameTypes.Cricket)
            {
                int numberofPlayers = AppConstant.Constant.CricketPlayers;
                List<Teams> team = CreateTeamForGame(game.Players, game.GameType, numberofPlayers);
                teams.AddRange(team);
            }
            else if (game.GameType == GameTypes.Badminton)
            {
                int numberofPlayers = AppConstant.Constant.BedMintonPlayers;
                List<Teams> team = CreateTeamForGame(game.Players, game.GameType, numberofPlayers);
                teams.AddRange(team);
            }
            else if (game.GameType == GameTypes.Chess)
            {
                int numberofPlayers = AppConstant.Constant.ChessPlayer;
                List<Teams> team = CreateTeamForGame(game.Players, game.GameType, numberofPlayers);
                teams.AddRange(team);
            }
            _teamRepository.AddTeam(teams);
            return teams;
        }

        public static List<Teams> CreateTeamForGame(List<Player> players, GameTypes gameType, int numberofPlayers)
        {
            List<Teams> teams = new List<Teams>();
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
                    Teams team = new Teams()
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

        public List<Team> GetTeams(int gameId, int eventId)
        {
            List<Team> teams = _teamRepository.GetTeam(gameId, eventId);
            return teams;
        }
    }
}