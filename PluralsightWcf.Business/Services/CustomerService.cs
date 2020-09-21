using System;
using System.Collections.Generic;
using PluralsightWcf.Business.Models;

namespace PluralsightWcf.Models.Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
    }

    public class CustomerService : ICustomerService
    {
        public IEnumerable<Customer> GetCustomers()
        {
            //TODO: implement with Data Access Layer
            return new List<Customer> { 
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FullName = "Sandra Smith",
                    Email = "sandra.smith@email.com"
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    FullName = "Steven Spielberg",
                    Email = "steven.spielberg@email.com"
                }
            };
        }
    }
}
