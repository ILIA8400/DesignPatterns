using Decorator;

SimpleCoffee simpleCoffee = new SimpleCoffee();
Console.WriteLine(simpleCoffee.Description() + " => with price : " + simpleCoffee.Cost());

Milk milk = new(simpleCoffee);
Console.WriteLine(milk.Description() + " => with price : " + milk.Cost());

Chocolate chocolate = new(milk);
Console.WriteLine(chocolate.Description() + " => with price : " + chocolate.Cost());

Console.WriteLine();