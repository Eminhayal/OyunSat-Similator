using OyunSatısSimilator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatısSimilator.Abstract
{
    public interface ICustomerService
    {
        void Add(GamerCustomer gamerCustomer);
        void Update(GamerCustomer gamerCustomer);
        void Delete(GamerCustomer gamerCustomer);
    }
}
