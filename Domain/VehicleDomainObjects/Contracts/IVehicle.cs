namespace Domain.VehicleDomainObjects.Contracts
{
    public interface IVehicle
    {
        string Name { get; }

        void TurnOn();

        void TurnOff();
    }
}
