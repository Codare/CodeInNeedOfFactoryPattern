using System;
using Domain.VehicleDomainObjects.Contracts;
using Domain.VehicleDomainObjects.Vehicles;

namespace ConsoleApp.CodeInNeedOfFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the car manufacturer.");
            string carManufacturer = Console.ReadLine();

            IVehicle car = GetCar(carManufacturer);
            car.TurnOn();
            car.TurnOff();

            Console.ReadLine();
        }

        static IVehicle GetCar(string carManufacturer)
        {
            //The reason that this code is considered bad/harmful is that the client code needs to change when a new Vehicle type/manufacturer is required.
            //Thus we need to write a better implementation that allows the client to not be concerned with the new operator.  This is deferred to another location.
            //Effectively moving this switch statement to another location of the codebase.
            switch (carManufacturer)
            {
                case "bmw":
                    return new BMWZ9();
                default:
                    return null;
            }
        }
    }
}
