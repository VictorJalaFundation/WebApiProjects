using Api_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Project.Services
{
    public interface IGamesService
    {
        IEnumerable<Games> GetGamesList();
        Games GetGamesById(string id);
    }
}
