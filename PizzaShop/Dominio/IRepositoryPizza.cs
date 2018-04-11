using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IRepositoryPizza
    {
        Pizza Add(Pizza pizza);
        Pizza Update(Pizza pizza);
    }
}
