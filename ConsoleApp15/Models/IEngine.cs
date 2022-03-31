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
        public int TankSize { get; set; }

        public int CurrentFuel { get; set; }

        public string FuelType { get; set; }
        void LeftFuelAmount();

    }
}
