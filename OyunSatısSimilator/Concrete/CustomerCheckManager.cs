using OyunSatısSimilator.Abstract;
using OyunSatısSimilator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatısSimilator.Concrete
{
    public class CustomerCheckManager : ICustomerCheckPersonService
    {
        public bool CheckPerson(GamerCustomer gamerCustomer)
        {
            return true; 
        }
    }
}
