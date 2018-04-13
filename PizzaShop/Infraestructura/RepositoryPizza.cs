using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Infraestructura
{
    public class RepositoryPizza : IRepositoryPizza
    {
        readonly IUnitOfWork _unitOfWork;
        public RepositoryPizza(IUnitOfWork unitOfWork)
        {
            
        }
        public Pizza  Add(Pizza pizza)
        {
            _unitOfWork.Add(pizza);
            return pizza;
        }

        public Pizza Update(Pizza pizza)
        {
            throw new NotImplementedException();
        }
        public void Save()
        {
            _unitOfWork.SaveChanges();
        }

        public DbSet IDbSet(Type type)
        {
            throw new NotImplementedException();
        }
    }
}
