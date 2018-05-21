using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    /// The 'Concrete Builder 3' class implementation.
    /// </summary>
    public class ScooterBuilder : VehicleBuilder
    {
        // ctor
        public ScooterBuilder()
        {
            vehicle = new Vehicle(VehicleType.Scooter);
        }
        public override void BuildAirbags()
        {
            vehicle["airBag"] = "0";
        }

        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "300 CC";
        }

        public override void BuildFrames()
        {
            vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildPowerWindow()
        {
            vehicle["PowerWindow"] = "0";
        }

        public override void BuildSmartLock()
        {
            vehicle["smartLock"] = " smart Lock";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
    }
}
