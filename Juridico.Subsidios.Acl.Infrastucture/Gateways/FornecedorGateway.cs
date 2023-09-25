using Flunt.Notifications;
using Juridico.Subsidios.Acl.Domain.Extensions;
using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.Filtros;
using RestSharp;
using RestSharp.Serializers;
using static Juridico.Subsidios.Acl.Domain.Extensions.XmlExtensions;

namespace Juridico.Subsidios.Acl.Infrastucture.Gateways
{
    public class FornecedorGateway : IFornecedorGateway
    {
        public async Task<TReturn> ExecuteAsync<TFilter, TReturn>(TFilter filter, string mockRetorno)
            where TFilter : FiltrosBase
            where TReturn : Notifiable<Notification>
        {
            var requestObject = EnvelopeXml<TFilter>.CriarEnvelope(filter);
            var envelope = SerializeXmlObject<TFilter>.SerializarObjeto(requestObject);

            var baseUrl = new Uri(Environment.GetEnvironmentVariable("FORNECEDOR_URL"));
            var request = new RestRequest($"{baseUrl}/processo", Method.Post);
            request.AddHeader("Content-Type", "text/xml");

            if (!request.Parameters.Any(p => p.Name == "text/xml"))
                request.AddParameter("text/xml", envelope, ParameterType.RequestBody);

            var response = XmlExtensions.Get(mockRetorno);

            return response.DeserializeXml<TReturn>();
        }
    }
}
