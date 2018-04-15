using Akka.Actor;
using BaseActores.Controllers;

namespace BaseActores.Entidades
{
    public partial class EntidadActor : ReceiveActor
    {
        public Entidad EntidadState { get; set; }
        private IActorRef EntidadActorRef { get; set; }

        public EntidadActor(IActorRef entidadActor) {
            this.EntidadState = new Entidad();
            this.EntidadActorRef = entidadActor;

            Receive<ConsultarEntidad>(_ => Sender.Tell(this.EntidadState));     
        }

        public static Props Props(IActorRef entidadActor)
        {
            return Akka.Actor.Props.Create(() => new EntidadActor(entidadActor));
        }

    }
}
