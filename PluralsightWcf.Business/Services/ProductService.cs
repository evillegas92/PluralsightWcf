using System.Collections.Generic;
using PluralsightWcf.Business.Models;

namespace PluralsightWcf.Models.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }

    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            //TODO: implement with data access layer
            return new List<Product> { 
                new Product
                {
                    Id = 1,
                    Name = "Product One",
                    Description = "Product one description.",
                    Type = "TypeA"
                },
                new Product
                {
                    Id = 2,
                    Name = "Product Two",
                    Description = "Product two description.",
                    Type = "TypeB"
                },
                new Product
                {
                    Id = 3,
                    Name = "Product Three",
                    Description = "Product three description.",
                    Type = "TypeB"
                }
            };
        }
    }
}
