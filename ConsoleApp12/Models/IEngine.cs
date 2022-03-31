using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    interface IEngine
    {
       
            public int HoursePower { get; set; }
            public int FuelRate { get; set; }
            public int CurrentFuel { get; set; }
            public int FuelType { get; set; }
            public abstract int LeftFuelAmount();
        
    }
}
