using Api_Project.Data;
using Api_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Project.Services
{
    public class GamesService:IGamesService
    {
        private readonly IGamesRepo _gamesRepo;

        public GamesService(IGamesRepo gamesRepo)
        {
            _gamesRepo = gamesRepo;
        }

        public IEnumerable<Games> GetGamesList()
        {
            return _gamesRepo.getGamesList();
        }

        public Games GetGamesById(string id)
        {
            return _gamesRepo.getGamesById(id);
        }
    }
}
