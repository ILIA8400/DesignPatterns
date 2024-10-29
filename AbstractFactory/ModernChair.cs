using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ModernChair : Chair
    {
        public override void Build()
        {
            Console.WriteLine($"{nameof(ModernChair)} was created.");
        }
    }
}
