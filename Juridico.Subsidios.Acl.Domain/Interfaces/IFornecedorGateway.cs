using Flunt.Notifications;
using Juridico.Subsidios.Acl.Domain.Models.Filtros;

namespace Juridico.Subsidios.Acl.Domain.Interfaces
{
    public interface IFornecedorGateway
    {
        Task<TReturn> ExecuteAsync<TFilter, TReturn>(TFilter filter, string mockRetorno)
            where TFilter : FiltrosBase
            where TReturn : Notifiable<Notification>;
    }
}