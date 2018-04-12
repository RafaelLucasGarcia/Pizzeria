using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    class RepositoryIngredient : IRepositoryIngredient
    {
        readonly IUnitOfWork _unitOfWork;
        public RepositoryIngredient(IUnitOfWork unitOfWork)
        {

        }
        public Ingredient Add(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        }
        public void Save()
        {
            _unitOfWork.SaveChanges();
        }
    }
}
