using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using PluralsightWcf.WebClient.OrderManagementWcf;
using PluralsightWcf.WebClient.Proxies;

namespace PluralsightWcf.WebClient.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IOrderManagementProxy _orderManagementProxy = new OrderManagementProxy();

        // GET: Products
        public async Task<ActionResult> Index()
        {
            List<Product> products = await _orderManagementProxy.GetProducts();
            return View(products);
        }
    }
}