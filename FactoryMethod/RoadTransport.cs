using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class RoadTransport : ITransportation
    {
        private readonly string roadLine;

        public RoadTransport(string roadLine) 
        {
            this.roadLine = roadLine;
        }


        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("Road Transport has begun.");
            Console.WriteLine($"RoadLine is : {roadLine}");
        }
    }
}
