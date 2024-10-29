using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample1
{
    public class ShadowDecorator : ShapeDecorator
    {
        public ShadowDecorator(IShape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            base.Draw();
            AddShadow();
        }

        public void AddShadow()
        {
            Console.WriteLine("Adding a Shadow");
        }
    }
}
