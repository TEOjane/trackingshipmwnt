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
        _goodsRepository.GetLocation(goods);
    }

    public Goods GetCargoInfo(long cargoId)
    {
        return _goodsRepository.GetCargoInfo(cargoId);
    }

    public long AddCargo(Goods goods)
    {
        return _goodsRepository.AddCargo(goods);
    }

    public Company GetCarrierInfo(long carrierId)
    {
        return _goodsRepository.GetCarrierInfo(carrierId);
    }

    public Truck GetTruckInfo(string truckNumber)
    {
        return _goodsRepository.GetTruckInfo(truckNumber);
    }
}