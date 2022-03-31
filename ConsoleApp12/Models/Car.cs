using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    class Car:Vehicle
    {
        public int DoorCount { get; set; }
        public int WinCode { get; set; }

        public override double AverageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("car ");
        }
    }
}
