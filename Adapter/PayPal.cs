using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PayPal
    {
        public string PayPalProccess(double dollar)
        {
            return $"The process was done with the amount of {dollar.ToString("N")} Dollar";
        }
    }
}
