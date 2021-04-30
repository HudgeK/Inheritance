using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle
    {
        public string Name;
        public string Type;
        public string ShipName;
        public string PilotName;
        public string Squadron;
        public int Callsign;
        public Vehicle()
        {
            Console.WriteLine("Vehicle made.");
        }
        public Vehicle(string name)
        {
            if(name is null || name.Length < 1)
            {
                Name = "Unkown";
            }
            else
            {
                Name = name;
            }
            Console.WriteLine(Name);
        }
        public void VehicleType(Vehicle sentType)
        {
                Type = sentType.Type;
        }
    }
}
