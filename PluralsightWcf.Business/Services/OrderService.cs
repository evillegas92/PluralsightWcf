using PluralsightWcf.Business.Models;

namespace PluralsightWcf.Models.Services
{
    public interface IOrderService
    {
        OrderResponse AddOrder(Order newOrder);
    }

    public class OrderService : IOrderService
    {
        public OrderResponse AddOrder(Order newOrder)
        {
            //TODO: implement with data access layer.
            return new OrderResponse
            {
                Success = true,
                OrderId = 1
            };
        }
    }
}
