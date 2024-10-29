using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class OldFactory : IAbstractFactory
    {
        public Chair CreateChair()
        {
            return new OldChair();
        }

        public Desk CreateDesk()
        {
            return new OldDesk();
        }
    }
}
