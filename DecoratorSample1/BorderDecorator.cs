using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample1
{
    public class BorderDecorator : ShapeDecorator
    {
        public BorderDecorator(IShape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            base.Draw();
            AddBorder();
        }

        private void AddBorder()
        {
            Console.WriteLine("Adding a Border");
        }
    }
}
