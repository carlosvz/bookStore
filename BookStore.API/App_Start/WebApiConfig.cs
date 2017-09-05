﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BookStore.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web

            //Remove o xml formatter
            var formatter = GlobalConfiguration.Configuration.Formatters;
            formatter.Remove(formatter.XmlFormatter);

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}