using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    class Bicycle:Vehicle,IEngine,IWheel,ITransmission
    {
        public int PedalKind { get; set; }
        public int HoursePower { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Tanksize { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object TankSize { get; private set; }
        public int CurrentOil { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FuelType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IWheelThickness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ITransmissionKind { get; set; }
       
        public object WheelThickness { get; private set; }
        public object HorsePower { get; private set; }
        public object CurrentFuel { get; private set; }
        public object TransmissionKind { get; private set; }

        public int LeftOilAmount()
        {
            throw new NotImplementedException();
        }

        public override void ShowInfo()
        {
            Console.WriteLine($@"
                PedalKind-{PedalKind}
                TankSize-{TankSize}
                TransmissionKind-{TransmissionKind}
                WheelThickness-{WheelThickness}
                HorsePower-{HorsePower}
                CurrentFuel-{CurrentFuel}
                FuelType-{FuelType}");
        }
    }
}
