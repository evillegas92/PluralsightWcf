using System.Collections.Generic;
using System.Threading.Tasks;
using PluralsightWcf.WebClient.OrderManagementWcf;

namespace PluralsightWcf.WebClient.Proxies
{
    public interface IOrderManagementProxy
    {
        Task<List<Product>> GetProducts();
    }

    public class OrderManagementProxy : IOrderManagementProxy
    {
        private const string wcfHttpBindingName = "BasicHttpBinding_IOrderManagementService";

        public async Task<List<Product>> GetProducts()
        {
            using (OrderManagementServiceClient wcfClient = new OrderManagementServiceClient(wcfHttpBindingName))
            {
                List<Product> products = await wcfClient.GetProductsAsync();
                return products;
            }            
        }
    }
}
