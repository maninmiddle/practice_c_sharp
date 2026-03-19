using System;

class Program
{
   public static void Main()
   {
	Transport[] fleet = new Transport[]
	{
    	  new Car("Toyota Camry", 210, 7.5),
          new Truck("Volvo FH", 160, 25.0),
          new Car("BMW M5", 250, 10.5),
          new Truck("MAN TGX", 170, 22.0)
	};

	TransportManager manager = new TransportManager(fleet);

	Console.WriteLine("\nСписок транспорта:");
	manager.ShowAll();

	Console.WriteLine("\nСамый экономичный транспорт:");
	Console.WriteLine(manager.GetMostEfficientVehicle());

	Console.WriteLine("\nСамый быстрый транспорт:");
	Console.WriteLine(manager.GetFastestVehicle());
   }
}
