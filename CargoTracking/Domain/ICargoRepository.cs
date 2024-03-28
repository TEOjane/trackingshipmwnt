namespace Domain;

public interface ICargoRepository
{
    decimal CalcShippingCost(Cargo cargo);

    void GetLocation(Cargo cargo);

    Cargo GetCargoInfo(long cargoId);

    long AddCargo(Cargo cargo);

    Carrier GetCarrierInfo(long carrierId);

    Truck GetTruckInfo(string truckNumber);
}