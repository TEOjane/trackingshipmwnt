using Domain;

namespace Application;

public class ApplicationService : IApplicationService
{
    private ICargoRepository _cargoRepository;
    private IApplicationService _applicationServiceImplementation;

    public ApplicationService(ICargoRepository cargoRepository)
    {
        _cargoRepository = cargoRepository;
    }

    public decimal CalcShippingCost(Cargo cargo)
    {
        return _applicationServiceImplementation.CalcShippingCost(cargo);
    }

    public void GetLocation(Cargo cargo)
    {
        _applicationServiceImplementation.GetLocation(cargo);
    }

    public Cargo GetCargoInfo(long cargoId)
    {
        return _applicationServiceImplementation.GetCargoInfo(cargoId);
    }

    public long AddCargo(Cargo cargo)
    {
        return _applicationServiceImplementation.AddCargo(cargo);
    }

    public Carrier GetCarrierInfo(long carrierId)
    {
        return _applicationServiceImplementation.GetCarrierInfo(carrierId);
    }

    public Truck GetTruckInfo(string truckNumber)
    {
        return _applicationServiceImplementation.GetTruckInfo(truckNumber);
    }
}