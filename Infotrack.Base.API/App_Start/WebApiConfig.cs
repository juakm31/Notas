using System.Web.Http;

namespace Infotrack.Base.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //config.MessageHandlers.Add(new ValidadorJwt());
            //Configuración y servicios de API web
            config.EnableCors();
            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}