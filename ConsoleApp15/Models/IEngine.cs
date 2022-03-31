using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    interface IEngine
    {
        public int HorsePower { get; set; }
        public int FuelRate { get; set; }

        public int CurrentFuel { get; set; }

        public int FuelType { get; set; }
        void LeftFuelAmount();

    }
}
