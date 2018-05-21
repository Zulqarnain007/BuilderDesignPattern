using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Vehicle
    {
        private VehicleType _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        //constructor
        public Vehicle(VehicleType vehicleType)
        {
            _vehicleType = vehicleType;
        }

        // Indexer
        public string this[string key]
        {
            get
            {
                return _parts[key];
            }
            set
            {
                _parts[key] = value;
            }
        }

        public void Show()
        {
            Console.WriteLine("############## Builder Design Pattern - Vehicle Creation ######################");

            Console.WriteLine("Vehicle Type: {0}", _vehicleType);
            Console.WriteLine(" Frame : {0}", _parts["frame"]);
            Console.WriteLine(" Engine : {0}", _parts["engine"]);
            Console.WriteLine(" Wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" Doors : {0}", _parts["doors"]);
            Console.WriteLine(" Power Window : {0}", _parts["PowerWindow"]);
            Console.WriteLine(" Smart Lock : {0}", _parts["smartLock"]);
            Console.WriteLine(" Air bags : {0}", _parts["airBag"]);


            Console.WriteLine("############## Builder Design Pattern - Vehicle Creation ######################");
            Console.ReadLine();
        }
    }
}
