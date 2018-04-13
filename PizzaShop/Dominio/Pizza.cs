using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pizza
    {
        public Pizza()
        {
            this.Ingredients = new HashSet<Ingredient>();
            this.Comments = new HashSet<Comments>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
