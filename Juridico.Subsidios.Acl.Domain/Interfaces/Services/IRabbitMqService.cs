using Juridico.Subsidios.Acl.Domain.Models;

namespace Juridico.Subsidios.Acl.Domain.Interfaces.Services
{
    public interface IRabbitMqService
    {
        void Publish(SubsidioRetornoModel subsidio, string fila);
    }
}