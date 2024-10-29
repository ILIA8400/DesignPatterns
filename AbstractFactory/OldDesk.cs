using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class OldDesk : Desk
    {
        public override void Build()
        {
            Console.WriteLine($"{nameof(OldDesk)} was created.");
        }
    }
}
