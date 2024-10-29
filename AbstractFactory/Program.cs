using AbstractFactory;

IAbstractFactory factory = new ModernFactory();

var modernChair = factory.CreateChair();
var modernDesk = factory.CreateDesk();

modernChair.Build();
modernDesk.Build();