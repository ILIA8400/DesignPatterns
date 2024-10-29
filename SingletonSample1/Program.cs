using SingletonSample1;

Manager manager = Manager.CreateInstance();
Manager manager2 = Manager.CreateInstance();


Console.WriteLine(manager == manager2);