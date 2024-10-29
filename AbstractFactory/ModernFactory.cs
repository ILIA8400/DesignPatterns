using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ModernFactory : IAbstractFactory
    {
        public Chair CreateChair()
        {
            return new ModernChair();
        }

        public Desk CreateDesk()
        {
            return new ModernDesk();
        }
    }
}
