using Domain;

namespace Application;

public class ApplicationService : IApplicationService
{
    private IGoodsRepository _goodsRepository;

    public ApplicationService(IGoodsRepository goodsRepository)
    {
        _goodsRepository = goodsRepository;
    }

    public decimal CalcShippingCost(Goods goods)
    {
        return _goodsRepository.CalcShippingCost(goods);
    }

    public void GetLocation(Goods goods)
    {
        throw new NotImplementedException();
    }

    public Goods GetGoodsInfo(long goodsId)
    {
        return _goodsRepository.GetGoodsInfo(goodsId);
    }

    public long AddGoods(Goods goods)
    {
        throw new NotImplementedException();
    }

    public Company GetCompanyInfo(long carrierId)
    {
        throw new NotImplementedException();
    }

    public Truck GetTruckInfo(string truckNumber)
    {
        throw new NotImplementedException();
    }
}