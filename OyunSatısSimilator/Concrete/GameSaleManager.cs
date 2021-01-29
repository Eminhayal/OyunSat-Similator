using OyunSatısSimilator.Abstract;
using OyunSatısSimilator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatısSimilator.Concrete
{
    class GameSaleManager : ISell
    {
        public void Sell(Game game, BaseCustomerManager gamerCustomer)
        {
            Console.WriteLine("Oyununu satın aldınız. ");
        }
    }
}
