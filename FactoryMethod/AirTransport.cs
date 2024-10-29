using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AirTransport : ITransportation
    {
        private readonly string airLine;

        public AirTransport(string airLine)
        {
            this.airLine = airLine;
        }

        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Air Transport has begun.");
            Console.WriteLine($"AirLine is : {airLine}");
        }
    }
}
