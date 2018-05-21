using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    /// The 'Concrete Builder 1' class implementation.
    /// </summary>
    public class MotorCycleBuilder : VehicleBuilder
    {
        // ctor
        public MotorCycleBuilder()
        {
            vehicle = new Vehicle(VehicleType.MotorCycle);
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
            vehicle["engine"] = "150 CC";
        }

        public override void BuildFrames()
        {
            vehicle["frame"] = "MotorCycle Frame";
        }

        public override void BuildPowerWindow()
        {
            vehicle["PowerWindow"] = "0";
        }

        public override void BuildSmartLock()
        {
            vehicle["smartLock"] = " Hero Lock";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
    }
}
