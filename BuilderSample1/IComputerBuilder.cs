using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample1
{
    public interface IComputerBuilder
    {
        void SetCPU();
        void SetRAM();
        void SetStorage();
        void SetGraphicsCard();
        Computer GetComputer();
    }
}
