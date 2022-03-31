using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    class Car:Vehicle,IEngine,IWheel,ITransmission
    {
        public int DoorCount { get; set; }
        public int WinCode { get; set; }
        public int HoursePower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Tanksize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CurrentOil { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FuelType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IWheelThickness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ITransmissionKind { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int LeftOilAmount()
        {
            throw new NotImplementedException();
        }

        public override void ShowInfo()
        {
            Console.WriteLine($@"
                     DoorCount-{DoorCount}
                     WinCode-{WinCode}
                     HoursePower-{HoursePower}
                     Tanksize-{Tanksize}
                     CurrentOil-{CurrentOil}
                     FuelType-{FuelType}
                     IWheelThickness-{IWheelThickness}
                     ITransmissionKind-{ITransmissionKind}");




             
        }
    }
}
