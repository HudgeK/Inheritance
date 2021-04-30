using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Ship : Vehicle
    {
        public Ship()
        {
            Console.WriteLine("Ship made.");
        }
        public Ship(string name)
        {
            if (name is null || name.Length < 1)
            {
                ShipName = "Unkown";
            }
            else
            {
                ShipName = name;
            }
            Console.WriteLine(ShipName);
            Console.WriteLine(Type);
        }

    }
}
