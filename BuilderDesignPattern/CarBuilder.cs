using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    /// The 'Concrete Builder 2' class implementation.
    /// </summary>
    public class CarBuilder : VehicleBuilder
    {
        // ctor
        public CarBuilder()
        {
            vehicle = new Vehicle(VehicleType.Car);
        }
        public override void BuildAirbags()
        {
            vehicle["airBag"] = "2";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "3000 CC";
        }

        public override void BuildFrames()
        {
            vehicle["frame"] = "Car Frame";
        }

        public override void BuildPowerWindow()
        {
            vehicle["PowerWindow"] = "2 Power Window";
        }

        public override void BuildSmartLock()
        {
            vehicle["smartLock"] = " Godrej smart Lock";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }
    }
}
