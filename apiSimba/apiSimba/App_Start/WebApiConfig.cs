using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Owin;
using Microsoft.Owin;
using System.Net.Http.Formatting;

namespace apiSimba
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/v1/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
           
        }
    }
}
