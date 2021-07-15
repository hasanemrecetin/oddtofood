using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OddToFood.Core;

namespace OddToFood.Data.Services
{
    public class CustomerService : ICustomerService
    {
        List<Customer> CustomerList => new List<Customer>
        {
           new Customer {Id = 1, Name = "Ahmet Yıldırım"},
           new Customer {Id = 2, Name = "Mehmet Yıldız"},
           new Customer {Id = 3, Name = "Niyazi Baskesen"}
        };

        public List<Customer> getAll()
        {
            var result = CustomerList.OrderBy(x => x.Name).ToList();

            return result;
        }
    }
}
