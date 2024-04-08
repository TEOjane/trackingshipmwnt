using Domain;

namespace DataAccess;

public class GoodsRepository : IGoodsRepository
{
    private Dictionary<long, Goods> _dictionary;
    private long _id;

    public GoodsRepository()
    {
        _dictionary = new Dictionary<long, Goods>();
        _id = 0;
    }
    
    public decimal CalcShippingCost(Goods goods)
    {
        //same logic
        decimal cost = Convert.ToDecimal(goods.Weight + 100);
        
        return cost;
    }

    public void GetLocation(Goods goods)
    {
        throw new NotImplementedException();
    }

    public Goods GetGoodsInfo(long goodsId)
    {
        try
        {
            Goods goods = _dictionary[goodsId];
            return goods;
        }
        catch (Exception e)
        {
            throw new NotImplementedException();
        }
    }

    public long AddGoods(Goods goods)
    {
        _id++;
        goods.Id = _id;
        _dictionary.Add(_id, goods);

        return _id;
    }

    public Company GetCompanyInfo(long carrierId)
    {
        //Нужно возвращать информацию чисто о компании или окомпании-перевозчике конкретного груза?
        throw new NotImplementedException();
    }

    public Truck GetTruckInfo(string truckNumber)
    {
        throw new NotImplementedException();
    }
}