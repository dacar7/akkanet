using Akka.Actor;
using BaseActores.Entidades;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BaseActores.Controllers
{
    public class ConsultarEntidad
    {
        private ILogger<ConsultarEntidad> Logger { get; set; }
        private IActorRef EntidadActor { get; set; }

        public ConsultarEntidad(EntidadActorProvider provider, ILogger<ConsultarEntidad> logger)
        {
            this.Logger = logger;
            this.EntidadActor = provider.Get();
        }

        public async Task<Entidad> Execute(int entidadId)
        {
            Logger.LogInformation($"Consultando la entidad con ID '{entidadId}'");
            // return await this.EntidadActor.Ask<Entidad>(new EntidadActor.ConsultarEntidad(entidadId));
            return new Entidad();
        }
    }
}
