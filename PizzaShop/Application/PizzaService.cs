using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class PizzaService:IPizzaService
    {
        readonly IRepositoryPizza _repository;
        public PizzaService(IRepositoryPizza repository)
        {
            _repository = repository;
        }
        public Pizza Add(Pizza pizza)
        {
            return _repository.Add(pizza);  
            
        }

        public Pizza Update(Pizza pizza)
        {
            throw new NotImplementedException();
        }
    }
}
