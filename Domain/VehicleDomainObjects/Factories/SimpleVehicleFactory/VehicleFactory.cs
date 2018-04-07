using Domain.VehicleDomainObjects.Contracts;

namespace Domain.VehicleDomainObjects.Factories.SimpleVehicleFactory
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle GetVehicle();
    }
}
