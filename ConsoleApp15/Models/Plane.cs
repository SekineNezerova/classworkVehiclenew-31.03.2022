using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    class Plane:Vehicle
    {
        public int WingLength { get; set; }

        public override double AverageSpeed()
        {
            throw new NotImplementedException();
        }

        public override string ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
