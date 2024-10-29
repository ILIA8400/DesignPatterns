using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SimpleCoffee : ICoffee
    {
        public int Cost()
        {
            return 20;
        }

        public string Description()
        {
            return "Simple Coffee";
        }
    }
}
