using Vehicles.Models;

namespace Vehicles;

public class UltraGradeVehicleFactory : IVehicleFactory
{
    public IBike CreateBike() => new UltraGradeBike();
    public ICar CreateCar() => new UltraGradeCar();
}

public class UltraGradeCar : ICar
{
}

public class UltraGradeBike : IBike
{
}