using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseActores.Entidades
{
    public class EntidadActorProvider
    {
        private IActorRef EntidadActor { get; set; }

        public EntidadActorProvider(ActorSystem actorSystem)
        {
            var entidad = new Entidad { Id = 1, Nombre = "Prueba" }; // set sample data
            this.EntidadActor = actorSystem.ActorOf(Props.Create<EntidadActor>(entidad), "entidad");
        }

        public IActorRef Get()
        {
            return EntidadActor;
        }
    }
}
