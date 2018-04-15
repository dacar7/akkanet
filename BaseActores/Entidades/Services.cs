using BaseActores.Controllers;
using Microsoft.Extensions.DependencyInjection;

namespace BaseActores.Entidades
{
    public static class Services
    {
        public static void AddEntidadServices(this IServiceCollection services)
        {
            services.AddSingleton<EntidadActorProvider>();
            services.AddSingleton<ConsultarEntidad>();
            
        }
    }
}
