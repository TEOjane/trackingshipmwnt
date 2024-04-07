using Domain;

namespace Application;

public interface IApplicationService
{
    decimal CalcShippingCost(Goods goods);

    void GetLocation(Goods goods);

    Goods GetCargoInfo(long cargoId);

    long AddCargo(Goods goods);

    Company GetCarrierInfo(long carrierId);

    Truck GetTruckInfo(string truckNumber);
}