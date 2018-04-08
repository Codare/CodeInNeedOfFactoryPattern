using System;
using System.Collections.Generic;
using System.Reflection;
using Common;
using Domain.VehicleDomainObjects.Contracts;

namespace Domain.VehicleDomainObjects.Factories.SimpleVehicleFactory
{
    public class VehicleFactory
    {
        Dictionary<string, Type> _vehicles;

        public VehicleFactory()
        {
            GetVehicleTypesForFactory();
        }

        public Result<IVehicle> CreateInstance(string carManufacturer)
        {
            var typeToCreate = GetTypeToCreate(carManufacturer);

            if (typeToCreate.Value == null)
            {
                return
                    Result<IVehicle>.Fail<IVehicle>($"The {nameof(carManufacturer)} is not in the supported list");
            }

            return Result<IVehicle>.Ok(Activator.CreateInstance(typeToCreate.Value) as IVehicle);
        }

        Result<Type> GetTypeToCreate(string carManufacturer)
        {
            foreach (var vehicle in _vehicles)
            {
                if (vehicle.Key.Contains(carManufacturer))
                {
                    return Result<Type>.Ok(_vehicles[vehicle.Key]);
                }
            }

            return Result<Type>.Fail<Type>("No Type found");
        }

        void GetVehicleTypesForFactory()
        {
            _vehicles = new Dictionary<string, Type>();

            var typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IVehicle).ToString()) != null)
                {
                    _vehicles.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
