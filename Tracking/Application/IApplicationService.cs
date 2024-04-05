using Domain;

namespace Application;

public interface IApplicationService
{
    decimal CalcShippingCost(Cargo cargo);

    void GetLocation(Cargo cargo);

    Cargo GetCargoInfo(long cargoId);

    long AddCargo(Cargo cargo);

    Carrier GetCarrierInfo(long carrierId);

    Truck GetTruckInfo(string truckNumber);
}