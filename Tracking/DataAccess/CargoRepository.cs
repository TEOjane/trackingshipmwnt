using Domain;

namespace DataAccess;

public class CargoRepository : ICargoRepository
{
    public decimal CalcShippingCost(Cargo cargo)
    {
        decimal cost = Convert.ToDecimal(cargo.Weight + 100);

        return cost;
    }

    public void GetLocation(Cargo cargo)
    {
        throw new NotImplementedException();
    }

    public Cargo GetCargoInfo(long cargoId)
    {
        throw new NotImplementedException();
    }

    public long AddCargo(Cargo cargo)
    {
        throw new NotImplementedException();
    }

    public Carrier GetCarrierInfo(long carrierId)
    {
        throw new NotImplementedException();
    }

    public Truck GetTruckInfo(string truckNumber)
    {
        throw new NotImplementedException();
    }
}