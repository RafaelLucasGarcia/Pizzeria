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
        public IDbSet<Pizza> Pizza { get; set; }

        public Pizza Add(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public DbSet IDbSet(Type type)
        {
            return this.Set(type);
        }
    }
}
