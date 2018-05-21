using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    /// <summary>
    /// Builder Design Pattern Main Class.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = null;

            // Create Shop with Vehilce Builder
            Shop shop = new Shop();


            // Construct and build Vehicle
            Console.WriteLine("Please enter the no of the vehicle you want to make from the following list.");
            System.Console.WriteLine("========================================================");
            System.Console.WriteLine("1. Car, 2. MotorCycle, 3. ScooterBuilder");
            System.Console.WriteLine("========================================================");
            int vehicleType = Convert.ToInt16(Console.ReadLine());

            if (vehicleType == 1)
            {
                builder = new CarBuilder();
            }
            else if (vehicleType == 2)
            {
                builder = new MotorCycleBuilder();
            }
            else if (vehicleType == 3)
            {
                builder = new ScooterBuilder();
            }
            else
            {
                Console.WriteLine("Incorrect Vehicle Type entered...!");
            }
            
            shop.Build(builder);
            builder.Vehicle.Show();
        }
    }
}
