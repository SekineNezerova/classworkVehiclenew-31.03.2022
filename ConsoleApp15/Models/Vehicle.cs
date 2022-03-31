using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    abstract class Vehicle
    {
        private int _DriveTime;
        private int _DrivePath;
        public int DriveTime { get; set; }
        public int DrivePath { get; set; }


        public abstract double AverageSpeed();

        public abstract string ShowInfo();
       
    }
    
}
