using Api_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Project.Data
{
    public class FakeGamesRepo : IGamesRepo
    {
        private List<Games> localGames = new List<Games>
        {
            new Games()
            {
                Id = 1,
                Name = "Resident Evil 4",
                Distributor = "Capcom",
                Release = new DateTime(2005, 01, 11)
            },
            new Games()
            {
                Id = 2,
                Name = "Resident Evil 5",
                Distributor = "Capcom",
                Release = new DateTime(2009, 05, 5)
            },
            new Games()
            {
                Id = 3,
                Name = "Resident Evil 6",
                Distributor = "Capcom",
                Release = new DateTime(2012, 10, 2)
            },
        };

        public Games getGamesById(int id)
        {
            return localGames.Where(game => game.Id == id).FirstOrDefault();
        }

        public IEnumerable<Games> getGamesList()
        {
            return localGames;
        }
    }
}
