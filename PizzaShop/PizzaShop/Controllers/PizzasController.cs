using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Dominio;
using Infraestructura;

namespace PizzaShop.Controllers
{
    public class PizzasController : ApiController
    {
        //private PizzaShopContext db = new PizzaShopContext();
        private UnitOfWork _unitOfWork = new UnitOfWork();

        // GET: api/Pizzas
        public IEnumerable<Pizza> GetPizzas()
        {
            
            var lista =  _unitOfWork.PizzaRepository.Get();
            return lista;
        }

        // GET: api/Pizzas/5
        [ResponseType(typeof(Pizza))]
        public IHttpActionResult GetPizza(int id)
        {
            Pizza pizza = _unitOfWork.PizzaRepository.GetByID(id);
            if (pizza == null)
            {
                return NotFound();
            }

            return Ok(pizza);
        }

        // PUT: api/Pizzas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPizza(int id, Pizza pizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pizza.ID)
            {
                return BadRequest();
            }

            //db.Entry(pizza).State = EntityState.Modified;
            _unitOfWork.PizzaRepository.Insert(pizza);

            try
            {
                _unitOfWork.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pizzas
        [ResponseType(typeof(Pizza))]
        public IHttpActionResult PostPizza(Pizza pizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            
            _unitOfWork.PizzaRepository.Insert(pizza);
            _unitOfWork.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pizza.ID }, pizza);
        }

        // DELETE: api/Pizzas/5
        [ResponseType(typeof(Pizza))]
        public IHttpActionResult DeletePizza(int id)
        {
            Pizza pizza = _unitOfWork.PizzaRepository.GetByID(id);
            if (pizza == null)
            {
                return NotFound();
            }

            _unitOfWork.PizzaRepository.Delete(pizza);
            _unitOfWork.SaveChanges();

            return Ok(pizza);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _unitOfWork.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PizzaExists(int id)
        {
            return false;// _unitOfWork.PizzaRepository.Count(e => e.ID == id) > 0;
        }
    }
}