using Juridico.Subsidios.Acl.Domain.Interfaces;
using Juridico.Subsidios.Acl.Infrastucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juridico.Subsidios.Acl.Domain.Handlers
{
    public class SubsidiosHandler
    {
        private readonly IFornecedorGateway fornecedorGateway;

        public SubsidiosHandler(IFornecedorGateway fornecedorGateway)
        {
            this.fornecedorGateway = fornecedorGateway;
        }

        public string ObterProcesso(string processo) 
        {

          //  var processo = await fornecedorGateway.ExecuteAsync<ProcessoFornecedorModel, >

            return string.Empty;
        } 

    }
}
