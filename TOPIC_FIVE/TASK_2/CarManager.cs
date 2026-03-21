public class CarManager
{
    public static void Run()
    {
        Driver driver1 = new Driver("Алексей");
        Driver driver2 = new Driver("Ольга");

        Wheel[] extraWheels = { new Wheel("GoodYear"), new Wheel("Michelin") };

        Car[] cars = new Car[]
        {
            new Car("Sedan", 4, 150),
            new Car("SUV", 4, 200),
            new Car("SportCar", 4, 300)
        };

        cars[0].AssignDriver(driver1);
        cars[1].AssignDriver(driver2);

        Console.WriteLine("\n--- Демонстрация движения автомобилей ---");
        foreach (Car car in cars)
        {
            if (car.Driver != null)
            {
                car.Driver.Drive(car);
            }
            else
            {
                Console.WriteLine($"Автомобиль {car.Model} готов к поездке, но у него нет водителя.");
                car.StartEngine();
                car.Drive();
                car.StopEngine();
            }
            Console.WriteLine();
        }
        Console.WriteLine("---------------------------------------");
    }
}
