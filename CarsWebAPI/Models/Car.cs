using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsWebAPI.Models
{
    public class Car
    {
        public int Id { get; set; }
        public String Brand{ get; set; }
        public String Name{ get; set; }
        public String Condition{ get; set; }
        public double Miles{ get; set; }
        public String FuelType { get; set; }
        
    }
}
