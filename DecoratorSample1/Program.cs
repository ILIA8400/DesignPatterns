using DecoratorSample1;

IShape circle = new Circle();

IShape borderedCircle = new BorderDecorator(circle);
IShape shadowedBorderedCircle = new ShadowDecorator(borderedCircle);


Console.WriteLine("Drawing plain Circle:");
circle.Draw();

Console.WriteLine("\nDrawing Circle with Border:");
borderedCircle.Draw();

Console.WriteLine("\nDrawing Circle with Border and Shadow:");
shadowedBorderedCircle.Draw();