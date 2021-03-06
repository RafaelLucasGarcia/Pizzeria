﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Web.Http.Cors;
using Autofac;
using System.Reflection;
using Autofac.Integration.WebApi;
using Infraestructura;
using Dominio;

namespace PizzaShop
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //var cors = new EnableCorsAttribute("localhost", "*", "*");
            //config.EnableCors(cors);
            
            // Configuración y servicios de Web API
            // Configure Web API para usar solo la autenticación de token de portador.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Rutas de Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            var builder = new ContainerBuilder();

            //Conseguir configuración API
            config = GlobalConfiguration.Configuration;

            //Registrat web API controller
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());


            builder.RegisterType<Logger>().As<ILogger>().InstancePerRequest();
            builder.RegisterType<Repository>().As<IRepository>().InstancePerRequest();
            builder.RegisterType<PizzaContext>().As<IRepositoryPizza>().As<IUnitOfWork>().InstancePerRequest();

            //Inyectar solucionador de dependencia a ser Autofac
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

    }

}
