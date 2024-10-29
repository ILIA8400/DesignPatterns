using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PayPalAdapter : IPayment
    {
        private readonly PayPal payPal;

        public PayPalAdapter(PayPal payPal)
        {
            this.payPal = payPal;
        }


        public string PaymentProccess(double toman)
        {
            double dollar = toman / 63_000;

            return payPal.PayPalProccess(dollar);
            
        }
    }
}
