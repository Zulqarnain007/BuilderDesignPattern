using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    ///  The 'Builder' abstract class implementation.
    /// </summary>
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle;

        /// <summary>
        /// Get Vehicle Instance
        /// </summary>
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        // Abstract  Build Methods
        public abstract void BuildFrames();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
        public abstract void BuildSmartLock();
        public abstract void BuildAirbags();
        public abstract void BuildPowerWindow();





    }
}
