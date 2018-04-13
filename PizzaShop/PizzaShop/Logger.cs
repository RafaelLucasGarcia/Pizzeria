using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Dominio;
using Infraestructura;

namespace PizzaShop
{

    public class Logger:ILogger
    {
        readonly IRepository _repository;
        readonly IUnitOfWork _unitOfWork;
        public Logger(IRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public void Write(PizzaContext pizza)
        {
            _repository.Write(pizza);
            _unitOfWork.SaveChanges();
        }
    }

    public interface IRepository
    {
        void Write(PizzaContext pizza);
    }

    public class Repository : IRepository
    {
        readonly IRepositoryPizza _repositoryPizza;
        public Repository(IRepositoryPizza repositoryPizza)
        {
            _repositoryPizza = repositoryPizza;
        }

        public void Write(PizzaContext pizza)
        {
            var set = _repositoryPizza.IDbSet(typeof(Pizza));
            set.Add(pizza);
        }
    }

    public interface ILogger:IDisposable
    {
        void Write(PizzaContext pizza);
    }
}