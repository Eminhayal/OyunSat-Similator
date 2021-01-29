using OyunSatısSimilator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatısSimilator.Entities
{
    public class GamerCustomer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public long IdentityNumber { get; set; }

        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set; }


    }
}
