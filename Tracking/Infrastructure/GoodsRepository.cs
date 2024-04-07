using Domain;

namespace DataAccess;

public class GoodsRepository : IGoodsRepository
{
    public decimal CalcShippingCost(Goods goods)
    {
        decimal cost = Convert.ToDecimal(goods.Weight + 100);

        return cost;
    }

    public void GetLocation(Goods goods)
    {
        throw new NotImplementedException();
    }

    public Goods GetCargoInfo(long cargoId)
    {
        throw new NotImplementedException();
    }

    public long AddCargo(Goods goods)
    {
        throw new NotImplementedException();
    }

    public Company GetCarrierInfo(long carrierId)
    {
        throw new NotImplementedException();
    }

    public Truck GetTruckInfo(string truckNumber)
    {
        throw new NotImplementedException();
    }
}