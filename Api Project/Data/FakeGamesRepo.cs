using Api_Project.Data.DbContext;
using Api_Project.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Api_Project.Data
{
    public class FakeGamesRepo : IGamesRepo
    {
        private readonly IGamesContext _context;

        public FakeGamesRepo(IGamesContext context)
        {
            _context = context;
        }

        public IEnumerable<Games> getGamesList()
        {
            var gamesList = _context.Games.Find(book => true).ToList();
            return gamesList;
        }

        public Games getGamesById(string id)
        {
            var currentGame = _context.Games.Find(game => game.Id == id).FirstOrDefault();
            return currentGame;
        }
    }
}
