using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample1
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU()
        {
            _computer.CPU = "Intel Core i5";
        }

        public void SetRAM()
        {
            _computer.RAM = "16GB";
        }

        public void SetStorage()
        {
            _computer.Storage = "512GB SSD";
        }

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = "Integrated Graphics";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}
