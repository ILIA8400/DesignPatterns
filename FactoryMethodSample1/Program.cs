using FactoryMethodSample1;

ICarFactory gasolineFactory = new GasolineCarFactory();
Car gasolineCar = gasolineFactory.CreateCar();
gasolineCar.Drive();

ICarFactory electricFactory = new ElectricCarFactory();
Car electricCar = electricFactory.CreateCar();
electricCar.Drive();