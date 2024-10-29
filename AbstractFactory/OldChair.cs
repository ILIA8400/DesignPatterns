using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class OldChair : Chair
    {
        public override void Build()
        {
            Console.WriteLine($"{nameof(OldChair)} was created.");
        }
    }
}
