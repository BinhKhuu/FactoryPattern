using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CeilingFan : IFan
    {
        public void SwitchOff()
        {
            Console.WriteLine("Off Ceiling fan");
        }

        public void SwitchOn()
        {
            Console.WriteLine("On Ceiling fan");
        }
    }
}
