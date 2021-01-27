using OyunSatısSimilator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatısSimilator.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Add(GamerCustomer gamerCustomer)
        {
            Console.WriteLine(gamerCustomer.Name +gamerCustomer.SurName + " Müşterisi eklendi." );
        }

        public void Delete(GamerCustomer gamerCustomer)
        {
            Console.WriteLine(gamerCustomer.Name + gamerCustomer.SurName + " Müşterisi silindi.");
        }

        public void Update(GamerCustomer gamerCustomer)
        {
            Console.WriteLine(gamerCustomer.Name + gamerCustomer.SurName + " Müşterisi güncellendi.");
        }
    }
}
