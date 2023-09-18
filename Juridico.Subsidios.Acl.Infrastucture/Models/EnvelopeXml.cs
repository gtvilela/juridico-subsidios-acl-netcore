using Juridico.Subsidios.Acl.Infrastucture.Extensions;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Infrastructure.Models
{
    /// <summary>
    /// Classe base para serialização do xml de envio ao fornecedor.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public static class EnvelopeXml<TEntity> where TEntity : class
    {
        public static Envelope<TEntity> CriarEnvelope(TEntity obj)
        {
            var envelope = new Envelope<TEntity>
            {
                Body = new EnvelopeBody<TEntity>
                {
                    Entidade = obj
                }
            };
            return envelope;
        }
    }

    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public class Envelope<TEntity>
    {
        public EnvelopeBody<TEntity> Body { get; set; }
    }

    [ExcludeFromCodeCoverage]
    [Serializable()]
    [XmlType(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class EnvelopeBody<TEntity>
    {
        [XmlIgnore]
        public TEntity Entidade { get; set; }

        [XmlAnyElement]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public XElement XmlEntity
        {
            get
            {
                return (Entidade == null ? null : XObjectExtensions.SerializeToXElement(Entidade, null, true));
            }
            set
            {
                Entidade = value == null ? Entidade : XObjectExtensions.Deserialize<TEntity>(value);
            }
        }
    }
}
