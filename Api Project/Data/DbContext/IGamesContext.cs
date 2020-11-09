using Api_Project.Models;
using MongoDB.Driver;

namespace Api_Project.Data.DbContext
{
    public interface IGamesContext
    {
        IMongoCollection<Games> Games { get; }
    }
}
