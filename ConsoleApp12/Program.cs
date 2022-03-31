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
            Console.WriteLine(car.AverageSpeed());
            
        }
    }
}
