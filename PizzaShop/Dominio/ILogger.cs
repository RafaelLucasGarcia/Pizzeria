using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface ILogger : IDisposable
    {
        void Write(Pizza pizza);
    }
}
