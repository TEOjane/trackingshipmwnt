using Domain;

namespace Application;

public interface IApplicationService
{
    decimal CalcShippingCost(Goods goods);

    void GetLocation(Goods goods);

    Goods GetGoodsInfo(long goodsId);

    long AddGoods(Goods goods);

    Company GetCompanyInfo(long carrierId);

    Truck GetTruckInfo(string truckNumber);
}