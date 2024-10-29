using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample1
{
    public class ElectricVehicleFactory : IVehicleFactory
    {
        public Car CreateCar()
        {
            return new ElectricCar();
        }

        public Engine CreateEngine()
        {
            return new ElectricEngine();
        }
    }
}
