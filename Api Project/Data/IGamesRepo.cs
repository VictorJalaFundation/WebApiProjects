using Api_Project.Models;
using System.Collections.Generic;

namespace Api_Project.Data
{
    public interface IGamesRepo
    {
        IEnumerable<Games> getGamesList();
        Games getGamesById(string id);
    }
}
