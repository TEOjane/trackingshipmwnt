using Domain;

namespace Application;

public class ApplicationService : IApplicationService
{
    private ICargoRepository _cargoRepository;

    public ApplicationService(ICargoRepository cargoRepository)
    {
        _cargoRepository = cargoRepository;
    }

    public decimal CalcShippingCost(Cargo cargo)
    {
        return _cargoRepository.CalcShippingCost(cargo);
    }

    public void GetLocation(Cargo cargo)
    {
        _cargoRepository.GetLocation(cargo);
    }

    public Cargo GetCargoInfo(long cargoId)
    {
        return _cargoRepository.GetCargoInfo(cargoId);
    }

    public long AddCargo(Cargo cargo)
    {
        return _cargoRepository.AddCargo(cargo);
    }

    public Carrier GetCarrierInfo(long carrierId)
    {
        return _cargoRepository.GetCarrierInfo(carrierId);
    }

    public Truck GetTruckInfo(string truckNumber)
    {
        return _cargoRepository.GetTruckInfo(truckNumber);
    }
}