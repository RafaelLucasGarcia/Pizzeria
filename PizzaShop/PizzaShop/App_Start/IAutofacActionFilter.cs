using Microsoft.Owin;

[assembly: OwinStartup(typeof(PizzaShop.Startup))]

namespace PizzaShop
{
    public interface IAutofacActionFilter { }
}


