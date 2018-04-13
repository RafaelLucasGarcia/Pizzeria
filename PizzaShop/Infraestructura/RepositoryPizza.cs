using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class RepositoryPizza : IRepositoryPizza, IDisposable
    {
        readonly IUnitOfWork _unitOfWork;
        private bool disposed = false;

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
        public void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _unitOfWork.Dispose();                    
                }
}
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
