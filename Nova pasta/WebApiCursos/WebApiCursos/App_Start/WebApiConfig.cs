using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiCursos
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
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}

//https://docs.microsoft.com/pt-br/aspnet/web-api/overview/advanced/calling-a-web-api-from-a-net-client
