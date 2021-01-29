using OyunSatısSimilator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatısSimilator.Entities
{
    public class Game : IEntities
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
    }
}
