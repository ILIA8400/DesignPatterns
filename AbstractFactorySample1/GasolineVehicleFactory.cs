using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample1
{
    public class GasolineVehicleFactory : IVehicleFactory
    {
        public Car CreateCar()
        {
            return new GasolineCar();
        }

        public Engine CreateEngine()
        {
            return new GasolineEngine();
        }
    }
}
