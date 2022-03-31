using ConsoleApp15.Models;
using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.DoorCount = 4;
            car.WinCode = 869668;
            car.TransmissionKind = "Automatic";
            car.HorsePower = 500;
            car.WheelThickness = 20;
            car.ShowInfo();
            
          
          
        }
    }
}
