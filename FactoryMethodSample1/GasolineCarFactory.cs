using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodSample1
{
    public class GasolineCarFactory : ICarFactory
    {
        public Car CreateCar()
        {
            return new GasolineCar();
        }
    }
}
