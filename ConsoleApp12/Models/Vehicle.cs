using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
   abstract class Vehicle
    {
        private int _DriveTime;
        private int _DrivePath;
        public int DriveTime 
        {
            get{ return _DrivePath;  }
            set
            {
             
            }
        }
        public int DrivePath { get; set; }
        public abstract double AverageSpeed();
        public abstract void ShowInfo();
    }
}
