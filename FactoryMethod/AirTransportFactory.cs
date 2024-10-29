using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AirTransportFactory : ITransportationFactory
    {
        private readonly string airLine;

        public AirTransportFactory(string airLine)
        {
            this.airLine = airLine;
        }

        public ITransportation CreateTransportation()
        {
            return new AirTransport(airLine);
        }
    }
}
