using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Pilot : Ship
    {
        public Pilot()
        {
            Console.WriteLine("Pilot found.");
        }
        public Pilot(string name, string squad, int num)
        {
            if (name is null || name.Length < 1)
            {
                PilotName = "Unkown";
            }
            else
            {
                PilotName = name;
            }
            if (squad is null || squad.Length < 1)
            {
                Squadron = "Unkown";
            }
            else
            {
                Squadron = squad;
            }
            Callsign = num;
            Console.WriteLine(PilotName);
            Console.WriteLine(Squadron + " " + Callsign);
        }
    }
}
