using OyunSatısSimilator.Abstract;
using OyunSatısSimilator.concrete;
using OyunSatısSimilator.Entities;
using System;

namespace OyunSatısSimilator
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new GamerCustomerManager(ICustomerCheckPersonService);
            customerManager.Add(new GamerCustomer{ Name= "Emin" , SurName="Hayal", DateOfBirth = new DateTime(1999, 6, 4) , TcNo="123213123" });
            
        }
    }
}
