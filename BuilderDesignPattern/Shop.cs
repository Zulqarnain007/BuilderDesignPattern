using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{

    /// <summary>
    /// The 'Director' class implementation.
    /// </summary>
    public class Shop
    {
        // Builder uses a complex set of  steps.
        public void Build(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrames();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
            vehicleBuilder.BuildPowerWindow();
            vehicleBuilder.BuildSmartLock();
            vehicleBuilder.BuildAirbags();

        }
    }
}
