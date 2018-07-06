using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using XR.Repository;
using XR.Repository.Data;

namespace XR
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务

            // Web API 路由
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //new TestData().Add();

            var result = new TestData().IQueryable().ToList()[0].Name;

            Console.WriteLine( "aaaaaaaaaaaaaaaaa"+ result);
        }
    }
}
