using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResSample1.Middlewares
{
    public class LoggingMiddleware : Kernel
    {
        public override object Handler(object request)
        {
            Console.WriteLine("Logging middleware handled the request.");
            Console.WriteLine("========================================");

            return base.Handler(request);
        }
    }
}
