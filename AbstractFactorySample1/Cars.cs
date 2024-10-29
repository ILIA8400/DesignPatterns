using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample1
{
    public class GasolineCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a gasoline car.");
        }
    }

    public class ElectricCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Driving an electric car.");
        }
    }
}
