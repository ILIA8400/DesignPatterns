using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResSample1
{
    public abstract class Kernel : IMiddleware
    {
        private IMiddleware _next;
        public virtual object Handler(object request)
        {
            if (_next != null) return _next.Handler(request);
            else return null;
        }

        public IMiddleware Next(IMiddleware middleware)
        {
            _next = middleware;

            return _next;
        }
    }
}
