using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class RepositoryPizza : IRepositoryPizza
    {
        readonly IUnitOfWork _unitOfWork;
        public RepositoryPizza(IUnitOfWork unitOfWork)
        {
            
        }
        public Pizza Add(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public Pizza Update(Pizza pizza)
        {
            throw new NotImplementedException();
        }
        public void Save()
        {
            _unitOfWork.SaveChanges();
        }
    }
}
