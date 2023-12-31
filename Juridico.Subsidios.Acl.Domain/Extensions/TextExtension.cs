﻿using System.Text;

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

        public static string ToCamelCase(this string str)
        {
            return char.ToLower(str[0]) + str.Substring(1);
        }
    }
}
