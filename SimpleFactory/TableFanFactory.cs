using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// Factory methods where each product has its own factory class. 
    /// To add more fans extend the IFactoryMethodFanFactory with a new class
    /// Client code will call a specific factory to get the correct fan
    /// client code is coupled to the factory
    /// </summary>
    public class TableFanFactory : IFactoryMethodFanFactory
    {
        public IFan CreateFan()
        {
            return new TableFan();
        }
    }

    public class CeilingFanFactory : IFactoryMethodFanFactory
    {
        public IFan CreateFan()
        {
            return new CeilingFan();
        }
    }

    public class ExhaustFanFactory : IFactoryMethodFanFactory
    {
        public IFan CreateFan()
        {
            return new ExhaustFan();
        }
    }
}
