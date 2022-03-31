using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    class Car:Vehicle
    {
        public int DoorCount { get; set; }
        public int WinCode { get; set; }

        public override double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public override string ShowInfo()
        {
            return $"doorcount-{DoorCount}-wincode-{WinCode}";
        }
    }
}
