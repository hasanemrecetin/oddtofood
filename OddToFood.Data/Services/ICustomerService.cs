using OddToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OddToFood.Data.Services
{
    public interface ICustomerService
    {
        List<Customer> getAll();
    }
}
