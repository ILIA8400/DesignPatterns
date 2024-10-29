using BuilderSample1;

Console.WriteLine();
Console.WriteLine("".PadLeft(40, '=') + " Gaming Computer " + "".PadLeft(40, '='));
Console.WriteLine();

IComputerBuilder gamingBuilder = new GamingComputerBuilder();
ComputerDirector director = new ComputerDirector(gamingBuilder);
director.BuildComputer();
Computer gamingComputer = director.GetComputer();
Console.WriteLine(gamingComputer);

Console.WriteLine();
Console.WriteLine("".PadLeft(40, '=') + " Office Computer " + "".PadLeft(40, '='));
Console.WriteLine();

IComputerBuilder officeBuilder = new OfficeComputerBuilder();
director = new ComputerDirector(officeBuilder);
director.BuildComputer();
Computer officeComputer = director.GetComputer();
Console.WriteLine(officeComputer);