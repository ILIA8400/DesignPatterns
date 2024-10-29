using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class RoadTransportFactory : ITransportationFactory
    {
        private readonly string roadLine;

        public RoadTransportFactory(string roadLine)
        {
            this.roadLine = roadLine;
        }

        public ITransportation CreateTransportation()
        {
            return new RoadTransport(roadLine);
        }
    }
}
