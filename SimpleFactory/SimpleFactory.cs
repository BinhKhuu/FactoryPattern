using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    /// <summary>
    /// Simple factory only one method that creates the fans for you.
    /// to add more fan types extend the product and modify the switch statement
    /// Client code will call the method and give it the fan type it wants
    /// client code is coupled to the product type
    /// </summary>
    public class SimpleFactory : IFanFactory
    {
        public SimpleFactory() { }   
        public IFan CreateFan(Type fanType)
        {
            return fanType switch
            {
                Type t when t == typeof(TableFan) => new TableFan(),
                Type t when t == typeof(CeilingFan) => new CeilingFan(),
                Type t when t == typeof(ExhaustFan) => new ExhaustFan(),
                _ => throw new ArgumentException(nameof(fanType), "is not an expected value"),
            };
        }
    }
}
