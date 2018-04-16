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
        public string Name { get; set; }
        public decimal Cost { get; set; }

        /*public Ingredient(string name, decimal cost) {
            Name = name;
            Cost = cost;
        }*/
    }
}
