using ConsoleApp12.Models;
using System;

namespace ConsoleApp12
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Car car = new Car();
            car.AverageSpeed();
            car.ShowInfo();
            car.HoursePower = 500;
            car.WinCode = 535234;
            Plane plane = new Plane();
            plane.WingLength = 234;
            plane.ShowInfo();
        }
    }
}
