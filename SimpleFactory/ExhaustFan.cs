using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ExhaustFan : IFan
    {
        public void SwitchOff()
        {
            Console.WriteLine("Off Exhaust fan");
        }

        public void SwitchOn()
        {
            Console.WriteLine("On Exhaust fan");
        }
    }
}
