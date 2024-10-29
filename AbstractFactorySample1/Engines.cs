using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample1
{
    public class GasolineEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Starting a gasoline engine.");
        }
    }

    public class ElectricEngine : Engine
    {
        public override void Start()
        {
            Console.WriteLine("Starting an electric engine.");
        }
    }
}
