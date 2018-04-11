using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http.Cors;
using Microsoft.Owin.Cors;
using Autofac;
using System.Web.Http;
using Autofac.Integration.WebApi;
using System.Reflection;

[assembly: OwinStartup(typeof(PizzaShop.Startup))]

namespace PizzaShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            

            ConfigureAuth(app);
        }
    }
}


