using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Milk : CoffeeDecorator
    {
        public Milk(ICoffee coffee) : base(coffee)
        {
        }

        public override int Cost()
        {
            return base.Cost() + 15;
        }

        public override string Description()
        {
            return base.Description() + " + Milk";
        }
    }
}
