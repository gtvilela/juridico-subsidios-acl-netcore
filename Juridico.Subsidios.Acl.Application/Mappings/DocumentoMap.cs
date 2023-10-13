using AutoMapper;
using Juridico.Subsidios.Acl.Domain.Models;
using Juridico.Subsidios.Acl.Domain.Models.EnvioFornecedor;
using Juridico.Subsidios.Acl.Domain.Models.RetornoFornecedor;

namespace Juridico.Subsidios.Acl.Domain.Mappings
{
    public class DocumentoMap : Profile
    {
        public DocumentoMap()
        {
            CreateMap<DocumentoFornecedorRetornoModel, ProcessoModel>()
                .ForMember(dest => dest.Documentos, m => m.MapFrom(src => src.Documentos));

            CreateMap<DocumentoProcessoIntegracao, DocumentoModel>()
                .ForMember(dest => dest.CodigoProcesso, m => m.Ignore())
                .ForMember(dest => dest.CodigoTipoDocumento, m => m.MapFrom(src => Convert.ToInt32(src.CodigoTipoDocumento)))
                .ForMember(dest => dest.DataInclusao, m => m.MapFrom(src => src.DataDocumento))
                .ForMember(dest => dest.Base64, m => m.MapFrom(src => src.Arquivo));

            CreateMap<DocumentoModel, DocumentoFornecedorEnvioModel>()
                .ForMember(dest => dest.CodigoTipoDocumento, m => m.MapFrom(src => src.CodigoTipoDocumento));
        }
    }
}
