using ChainOfResSample1;
using ChainOfResSample1.Middlewares;

var logging = new LoggingMiddleware();
var test = new TestMiddleware();
var athorize = new AuthorizationMiddleware();

List<Kernel> pipeline = [athorize, logging, test];

for (int i = 0; i < pipeline.Count - 1; i++)
{
    pipeline[i].Next(pipeline[i + 1]);
}


while (true)
{
    Console.Write("Enter Request : ");
    string request = Console.ReadLine();
    Console.WriteLine();

    var result = pipeline[0].Handler(request);

    Console.WriteLine("Response :");
    if (result != null) Console.WriteLine($"    {result}");
    else Console.WriteLine("    Error 404 Not Found");

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}
