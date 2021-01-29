using OyunSatısSimilator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatısSimilator.Abstract
{
    public interface ISell
    {
        public void Sell(Game game, BaseCustomerManager gamerCustomer);

    }
}
