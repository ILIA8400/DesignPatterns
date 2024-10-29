using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorSample1
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape shape;

        public ShapeDecorator(IShape shape)
        {
            this.shape = shape;
        }

        public virtual void Draw()
        {
            shape.Draw();
        }
    }
}
