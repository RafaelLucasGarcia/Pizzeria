using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; }
        public decimal Cost { get; }

        public Ingredient(string name, decimal cost) {
            Name = name;
            Cost = cost;
        }
    }
}
