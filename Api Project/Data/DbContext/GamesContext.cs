using Api_Project.Models;
using MongoDB.Driver;

namespace Api_Project.Data.DbContext
{
    public class GamesContext : IGamesContext
    {
        public GamesContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("VideoGames");
            Games = database.GetCollection<Games>("Games");
        }

        public IMongoCollection<Games> Games { get; }
    }
}
