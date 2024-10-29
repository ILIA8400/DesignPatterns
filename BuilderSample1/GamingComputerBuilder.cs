using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample1
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private readonly Computer _computer;
        public GamingComputerBuilder()
        {
            _computer = new Computer();
        }

        public Computer GetComputer()
        {
            return _computer;
        }

        public void SetCPU()
        {
            _computer.CPU = "Intel Core i9";
        }

        public void SetRAM()
        {
            _computer.RAM = "32GB";
        }

        public void SetStorage()
        {
            _computer.Storage = "1TB SSD";
        }

        public void SetGraphicsCard()
        {
            _computer.GraphicsCard = "NVIDIA GeForce RTX 3080";
        }
    }
}
