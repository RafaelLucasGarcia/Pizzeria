using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class PizzaContext:DbContext, IUnitOfWork, IRepositoryPizza
    {
        public PizzaContext()
        {
           
        }
        public IDbSet<Pizza> Pizzas { get; set; }

        public Pizza Add(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public Pizza Update(Pizza pizza)
        {
            throw new NotImplementedException();
        }
    }
}
