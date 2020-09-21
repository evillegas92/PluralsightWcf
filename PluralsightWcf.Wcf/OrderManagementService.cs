using System.Collections.Generic;
using System.ServiceModel;
using PluralsightWcf.Business.Models;
using PluralsightWcf.Models.Services;

namespace PluralsightWcf.Wcf
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class OrderManagementService : IOrderManagementService
    {
        private readonly ICustomerService _customerService = new CustomerService(); //TODO: replace with dependency injection.
        private readonly IProductService _productService = new ProductService(); //TODO: replace with dependency injection.
        private readonly IOrderService _orderService = new OrderService(); //TODO: replace with dependency injection.

        public IEnumerable<Customer> GetCustomers()
        {
            return _customerService.GetCustomers();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public OrderResponse SubmitOrder(Order order)
        {
            return _orderService.AddOrder(order);
        }
    }
}
