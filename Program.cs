using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilot Luke = new Pilot("Luke Skywalker", "Red", 5);
            Ship X_Wing = new Ship("X-Wing Fighter");
            Vehicle Spaceship = new Vehicle("Spaceship");
            Spaceship.Type = "Spaceship";
            X_Wing.VehicleType(Spaceship);
            Console.ReadLine();
        }
    }
}