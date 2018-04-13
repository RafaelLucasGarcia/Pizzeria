using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PizzaShop.Models;

namespace Dominio
{
    public class Comments
    {
        public int ID { get; set; }
        public string Comentario { get; }
        public int Valoracion { get; }
        public bool Validado { get; }
        //public ApplicationUser Usuario { get; }
    }
}
