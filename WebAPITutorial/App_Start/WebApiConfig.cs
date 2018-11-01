using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPITutorial
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // For eg. Legacy Api methods, redirecting to the new ones
            config.Routes.MapHttpRoute(
                name: "ProdAPI",
                routeTemplate: "api/prod/{id}",
                defaults: new { controller = "products", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{id}",
               defaults: new { id = RouteParameter.Optional }
           );


        }
    }
}
