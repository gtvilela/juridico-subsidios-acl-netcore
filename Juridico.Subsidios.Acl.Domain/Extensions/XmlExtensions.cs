using Juridico.Subsidios.Acl.Domain.Models;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Juridico.Subsidios.Acl.Domain.Extensions
{
    public static class XmlExtensions
    {
        public sealed class Utf8StringWriter : StringWriter
        {
            public override Encoding Encoding => Encoding.UTF8;
        }

        public static class SerializeXmlObject<TEntity>
        {
            public static string SerializarObjeto(Envelope<TEntity> envelope)
            {
                var stringwriter = new Utf8StringWriter();
                var serializer = new XmlSerializer(typeof(Envelope<TEntity>));

                serializer.Serialize(stringwriter, envelope);
                var objetoSerializado = stringwriter.ToString();

                return objetoSerializado;
            }
        }
        public static string Get(this string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            return doc.ToString();
        }

        public static T DeserializeXml<T>(this string xml)
        {
            using (TextReader reader = new StreamReader(xml))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }
    }

}
