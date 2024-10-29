using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResSample1
{
    public interface IMiddleware
    {
        IMiddleware Next(IMiddleware middleware);
        object Handler(object request);
    }
}
