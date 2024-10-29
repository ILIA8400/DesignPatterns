using AbstractFactorySample1;

ElectricVehicleFactory vehicleFactory = new ElectricVehicleFactory();
vehicleFactory.CreateEngine().Start();
vehicleFactory.CreateCar().Drive();

Console.WriteLine();
//===========================

GasolineVehicleFactory gasolineVehicleFactory = new GasolineVehicleFactory();
gasolineVehicleFactory.CreateEngine().Start();
gasolineVehicleFactory.CreateCar().Drive();