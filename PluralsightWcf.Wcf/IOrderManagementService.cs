using System.Collections.Generic;
using System.ServiceModel;
using PluralsightWcf.Business.Models;

namespace PluralsightWcf.Wcf
{
    [ServiceContract]
    public interface IOrderManagementService
    {
        [OperationContract]
        IEnumerable<Product> GetProducts();

        [OperationContract]
        IEnumerable<Customer> GetCustomers();

        [OperationContract]
        OrderResponse SubmitOrder(Order order);
    }
}
