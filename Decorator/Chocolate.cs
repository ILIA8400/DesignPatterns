using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Chocolate : CoffeeDecorator
    {
        public Chocolate(ICoffee coffee) : base(coffee)
        {
        }

        public override int Cost()
        {
            return base.Cost() + 20;
        }

        public override string Description()
        {
            return base.Description() + " + Chocolate";
        }
    }
}
