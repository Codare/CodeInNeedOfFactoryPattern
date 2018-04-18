using Domain.VehicleDomainObjects.Contracts;
using Domain.VehicleDomainObjects.Vehicles;

namespace Domain.VehicleDomainObjects.Factories.FactoryMethod
{
    public class BmwFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new BMWZ9();
        }
    }
}
