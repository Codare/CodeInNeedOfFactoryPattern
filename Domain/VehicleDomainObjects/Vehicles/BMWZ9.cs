using System;
using Domain.VehicleDomainObjects.Contracts;

namespace Domain.VehicleDomainObjects.Vehicles
{
    public class BMWZ9 : IVehicle
    {
        public string Name => "BMW Z9";

        public void TurnOn()
        {
            Console.WriteLine($"Turn on the: {Name}.");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Turn off the: {Name}.");
        }
    }
}
