using System.Text;

namespace Juridico.Subsidios.Acl.Domain.Extensions
{
    public static class TextExtension
    {
        public static string RetirarAcentuacaoMateriaLegal(this string materiaLegal)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            byte[] bytes = Encoding.GetEncoding("ISO-8859-8").GetBytes(materiaLegal);
            var materiaLegalCorrigida = Encoding.ASCII.GetString(bytes).ToLower();
            return materiaLegalCorrigida;
        }
    }
}
