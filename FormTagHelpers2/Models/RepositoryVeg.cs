using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTagHelpers2.Models
{
    public interface IRepositoryVeg
    {
        IEnumerable<Veg> Veges { get; }

        void AddVeg(Veg veggi);
    }
    public class VegRepo : IRepositoryVeg
    {
        private List<Veg> ListVeggies => new List<Veg>
        {
            new Veg {Name= "Carrot", Price = 1.80M, Qty= "5"},
            new Veg {Name= "Cabbage", Price= 1.50M, Qty= "2"},
            new Veg {Name = "Celery", Price = 2.20M, Qty= "3"}

        };
        public IEnumerable<Veg> Veges => ListVeggies;

        public void AddVeg(Veg veggi)
        {
            ListVeggies.Add(veggi);
        }
    }
}
