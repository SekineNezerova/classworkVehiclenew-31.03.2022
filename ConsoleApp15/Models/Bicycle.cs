using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    class Bicycle:Vehicle,IEngine,ITransmission,IWheel
    { 
        public int PedalKind { get; set; }
        public int HorsePower { get; set; }
        public int TankSize { get; set; }
        public int CurrentFuel { get; set; }
        public string FuelType { get; set; }
        public string TransmissionKind { get; set; }
        public int WheelThickness { get; set; }

      

        public void LeftFuelAmount()
        {
            throw new NotImplementedException();
        }

        public override void ShowInfo()
        {
            Console.WriteLine($@"
                {TankSize}-TankSize
                {TransmissionKind}-TransmissionKind
                {WheelThickness}-WheelThickness
                {HorsePower}-HorsePower
                {CurrentFuel}-CurrentFuel
                {FuelType}-FuelType");
        }
    }
}
