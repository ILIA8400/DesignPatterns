using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample1
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GraphicsCard { get; set; }

        public override string ToString()
        {
            return $"Computer Specifications: \nCPU: {CPU}\nRAM: {RAM}\nStorage: {Storage}\nGraphics Card: {GraphicsCard}";
        }
    }
}
