using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResSample1.Middlewares
{
    public class TestMiddleware : Kernel
    {
        public override object Handler(object request)
        {
            if ((request as string).Contains("Test")) return "Test Middleware Worked.";
            else return base.Handler(request);
        }
    }
}
