using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public interface IUnitOfWork:IDisposable
    {
        int SaveChanges();
        Pizza Add(Pizza pizza);
    }
}
