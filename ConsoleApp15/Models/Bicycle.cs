using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    class Bicycle:Vehicle
    { 
        public int PedalKind { get; set; }

        public override double AverageSpeed()
        {
             return DrivePath / DriveTime; ;
        }

        public override string ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
