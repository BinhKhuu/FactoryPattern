using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class TableFan : IFan
    {
        public void SwitchOff()
        {
            Console.WriteLine("Off table fan");
        }

        public void SwitchOn()
        {
            Console.WriteLine("On table fan");
        }
    }
}
