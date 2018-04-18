using System;
using Domain.VehicleDomainObjects.Contracts;

namespace ConsoleApp.FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Factory method lets a class defer instantiation to subclasses.
            //It adds an interface to the factory itself over and above a simple factory.

            Console.WriteLine("Code utilizing the Factory Method Pattern");

            var vehicleFactory = LoadFactory();

            //Defers object creation to multiple factories that share an interface.
            //Derived Classes aka the BmwFactory implement or override the factory method of the base ().
            var vehicle = vehicleFactory.CreateVehicle();

            vehicle.TurnOn();
            vehicle.TurnOff();

            Console.ReadLine();
        }

        static IVehicleFactory LoadFactory()
        {
            string factoryName = "Domain.VehicleDomainObjects.Factories.FactoryMethod.BmwFactory";  //Simulates an application setting from either a DB, NetworkService or AppSettings [App.config|web.config|settings]

            var assembly = typeof(IVehicleFactory).Assembly;
            var instance = assembly.CreateInstance(factoryName) as IVehicleFactory;

            return instance;
        }
    }
}
