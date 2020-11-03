using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Project.Models
{
    public class Games
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Distributor { get; set; }
        public DateTime Release { get; set; }
    }
}
