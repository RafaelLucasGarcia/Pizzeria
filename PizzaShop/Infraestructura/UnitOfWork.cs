using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Infraestructura
{
    public class UnitOfWork : IUnitOfWork { 
        private PizzaShopContext context = new PizzaShopContext();
        private GenericRepository<Ingredient> ingredientRepository;
        private GenericRepository<Pizza> pizzaRepository;
        private GenericRepository<Comments> commentRepository;

        
        public GenericRepository<Ingredient> IngredientesRepository
        {
            get
            {

                if (this.ingredientRepository == null)
                {
                    this.ingredientRepository = new GenericRepository<Ingredient>(context);
                }
                return ingredientRepository;
            }
        }

        public GenericRepository<Pizza> PizzaRepository
        {
            get
            {

                if (this.pizzaRepository == null)
                {
                    this.pizzaRepository = new GenericRepository<Pizza>(context);
                }
                return pizzaRepository;
            }
        }
        public GenericRepository<Comments> CommentsRepository
        {
            get
            {

                if (this.commentRepository == null)
                {
                    this.commentRepository = new GenericRepository<Comments>(context);
                }
                return commentRepository;
            }
        }

        

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int  SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}
