using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12.Models
{
    class Plane:Vehicle,IWheel,IEngine,ITransmission
    {
        public int WingLength { get; set; }
        public int IWheelThickness { get; set; }
        public int HoursePower { get; set; }
        public int Tanksize { get; set ; }
        public object TankSize { get; private set; }
        public int CurrentOil { get ; set; }
        public int FuelType { get; set ; }
        public int ITransmissionKind { get; set ; }
        public object TransmissionKind { get; private set; }
        public object WheelThickness { get; private set; }
        public object HorsePower { get; private set; }
        public object CurrentFuel { get; private set; }

        public int LeftOilAmount()
        {
            throw new NotImplementedException();
        }

        public override void ShowInfo()
        {
            Console.WriteLine($@"
                WingLength-{WingLength}
                TankSize-{TankSize}
                TransmissionKind-{TransmissionKind}
                WheelThickness-{WheelThickness}
                HorsePower-{HorsePower}
                CurrentFuel-{CurrentFuel}
                FuelType-{FuelType}");
        }
    }
}
