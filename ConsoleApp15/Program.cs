using ConsoleApp15.Models;
using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.ShowInfo();
            car.DoorCount = 4;
            car.WinCode = 869668;
            Console.WriteLine(car.ShowInfo());
          
          
        }
    }
}
