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
        public string Comentario { get; set; }
        public int Valoracion { get; set; }
        public bool Validado { get; set; }
        //public ApplicationUser Usuario { get; }
    }
}
