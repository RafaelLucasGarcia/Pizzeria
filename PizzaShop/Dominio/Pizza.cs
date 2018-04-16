using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pizza
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public byte Imagen { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
        public virtual List<Comments> Comments { get; set; }

        /*public Pizza(string name, List<Ingredient> ingredients, List<Comments> comments) {
            Name = name;
            Ingredients = ingredients;
            Comments = comments;

        }*/

    

    }
}
