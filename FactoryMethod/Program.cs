using FactoryMethod;

var airFactory = new AirTransportFactory(airLine: "123");
var air = airFactory.CreateTransportation();
air.Start();

var roadFactory = new RoadTransportFactory(roadLine: "566");
var road = roadFactory.CreateTransportation();
road.Start();