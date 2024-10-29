using Adapter;

//IPayment paymentMethod = new PayPal();  Throw Error
PayPal payPal = new PayPal();
IPayment paymentMethod = new PayPalAdapter(payPal);

Console.WriteLine(paymentMethod.PaymentProccess(1_000_000_000));