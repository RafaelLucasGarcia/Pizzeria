using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class PizzaShopContext:DbContext, IUnitOfWork
    {
        public PizzaShopContext()
        {
           
        }
        public IDbSet<Pizza> Pizzas { get; set; }
        public IDbSet<Ingredient> Ingredientes { get; set; }
        public IDbSet<Comments> Comentarios { get; set; }

        //public System.Data.Entity.DbSet<Dominio.Ingredient> Ingredients { get; set; }
    }
}
