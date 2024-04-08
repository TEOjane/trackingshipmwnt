namespace Domain;

public interface IGoodsRepository
{
    decimal CalcShippingCost(Goods goods);

    void GetLocation(Goods goods);

    Goods GetGoodsInfo(long cargoId);

    long AddGoods(Goods goods);

    Company GetCompanyInfo(long carrierId);

    Truck GetTruckInfo(string truckNumber);
}