using OyunSatısSimilator.Abstract;
using OyunSatısSimilator.concrete;
using OyunSatısSimilator.Concrete;
using OyunSatısSimilator.Entities;

using System;

namespace OyunSatısSimilator
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager gamerCustomer = new GamerCustomerManager(new CustomerCheckManager());
            gamerCustomer.Add(new GamerCustomer{ Name= "Emin" , SurName="Hayal", DateOfBirth = new DateTime(1999, 6, 4) , IdentityNumber = 123213123 });


            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sell(new Game { Id = 1, Name = "The Witcher" }, gamerCustomer) ;
        }
    }
}
