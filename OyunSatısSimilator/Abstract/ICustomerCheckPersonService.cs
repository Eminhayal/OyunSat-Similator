using OyunSatısSimilator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatısSimilator.Abstract
{
    public interface ICustomerCheckPersonService
    {
        bool CheckPerson(GamerCustomer gamerCustomer);
        
    }
}
