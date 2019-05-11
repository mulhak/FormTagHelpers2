using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTagHelpers2.Models
{
    public interface IRepository
    {
        IEnumerable<Fruit> Fruits { get; }

        void AddFruit(Fruit fruit);
    }

    public class FruitRepo : IRepository
    {
        private List<Fruit> fruits = new List<Fruit>
        {
            new Fruit {Name = "Banana", Price = 1.20M , Qty = 8},
            new Fruit {Name = "Apples" , Price = 2.50M , Qty = 7},
            new Fruit {Name = "Oranges", Price = 3.00M , Qty = 6},
        };

        public IEnumerable<Fruit> Fruits => fruits;

        public void AddFruit(Fruit fruit)
        {
            fruits.Add(fruit);
        }
    }
}
