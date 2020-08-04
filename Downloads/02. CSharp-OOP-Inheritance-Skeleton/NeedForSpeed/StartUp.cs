using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle(100,10);
            Console.WriteLine(vehicle.Drive(100));

            Car car = new Car(100, 10);
            Console.WriteLine(car.Drive(100));

            RaceMotorcycle raceMotorcycle = new RaceMotorcycle(100, 10);
            Console.WriteLine(raceMotorcycle.Drive(100));

            Console.ReadKey();

        }
    }
}
