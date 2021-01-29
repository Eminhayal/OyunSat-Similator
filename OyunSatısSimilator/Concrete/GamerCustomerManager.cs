using OyunSatısSimilator.Abstract;
using OyunSatısSimilator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatısSimilator.concrete
{
    public class GamerCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckPersonService _customerCheckPersonService;


        public GamerCustomerManager(ICustomerCheckPersonService customerCheckPersonService)
        {
            _customerCheckPersonService = customerCheckPersonService;
        }


        public override void Add(GamerCustomer gamerCustomer)
        {
            if (_customerCheckPersonService.CheckPerson(gamerCustomer)== true)
            {
                base.Add(gamerCustomer);
            }
            else
            {
                Console.WriteLine("Geçerli bir Müşteri değildir.");
            }
          
            
        }
        
        
    }
}
