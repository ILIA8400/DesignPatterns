using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ModernDesk : Desk
    {
        public override void Build()
        {
            Console.WriteLine($"{nameof(ModernDesk)} was created.");
        }
    }
}
