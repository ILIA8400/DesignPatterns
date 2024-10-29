using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResSample1.Middlewares
{
    public class AuthorizationMiddleware : Kernel
    {
        public override object Handler(object request)
        {
            if ((request as string).Contains("IP:1")) return "This IP has been blocked.";
            else return base.Handler(request);
        }
    }
}
