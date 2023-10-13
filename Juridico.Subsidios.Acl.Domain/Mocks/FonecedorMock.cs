namespace Juridico.Subsidios.Acl.Domain.Mocks
{
    public static class FornecedorMock
    {
        public const string XML_RETORNO_CONSULTA_PROCESSO = @"<?xml version='1.0' encoding='UTF-8'?>
																<Root>
																	<Codigo>16099</Codigo>
																	<SiglaUf>MG</SiglaUf>
																	<MateriaLegal>Cível</MateriaLegal>
																	<NumeroProcesso>00062-2003-014-04-00-3</NumeroProcesso>
																	<ProcessoEletronico>00062-2003-014-04-00-3</ProcessoEletronico>
																	<Usuario>123456</Usuario>
																	<NumeroCentroCusto>987654001</NumeroCentroCusto>
																	<CodigoFaseProcesso>2</CodigoFaseProcesso>
																	<CodigoAdvogadoAutor>00876</CodigoAdvogadoAutor>
																	<NomeReu>José da Silva</NomeReu>
																	<DataDistribuicao>20-09-2023</DataDistribuicao>
																	<DataRecebimento>25-09-2023</DataRecebimento>
																	<ValorEnvolvido>5000.00</ValorEnvolvido>
																	<Multa>500.00</Multa>
																	<Juros>10</Juros>
																	<Vara>2ª Vara Civel</Vara>
																</Root>";
        public const string XML_RETORNO_CONSULTA_COM_INFORMACOES_ADICIONAIS = @"<?xml version='1.0' encoding='UTF-8'?>
																			<Root>
																				<CodigoProcesso>16099</CodigoProcesso>
																				<InformacoesAdicionais>
																					<Element>
																						<Codigo>1</Codigo>
																						<Observacoes>Código do contrato com o cliente</Observacoes>
																						<Descricao>Contrato</Descricao>
																						<Usuario>123456</Usuario>
																						<InformacaoAdicional>XXX123456</InformacaoAdicional>
																					</Element>
																					<Element>
																						<Codigo>2</Codigo>
																						<Observacoes>Código da placa do veículo alugado pelo cliente</Observacoes>
																						<Descricao>Placa</Descricao>
																						<Usuario>123456</Usuario>
																						<InformacaoAdicional>RI02A18</InformacaoAdicional>
																					</Element>
																					<Element>
																						<Codigo>3</Codigo>
																						<Observacoes>Se há um condutor adicional cadastrado no contrato com o cliente.</Observacoes>
																						<Descricao>Condutor Adicional</Descricao>
																						<Usuario>123456</Usuario>
																						<InformacaoAdicional>Sim</InformacaoAdicional>
																					</Element>
																					<Element>
																						<Codigo>4</Codigo>
																						<Observacoes>Código do contrato com o cliente</Observacoes>
																						<Descricao>Código do Cliente</Descricao>
																						<Usuario>123456</Usuario>
																						<InformacaoAdicional>987654</InformacaoAdicional>
																					</Element>
																				</InformacoesAdicionais>
																			</Root>";
        public const string XML_RETORNO_CONSULTA_SEM_INFORMACOES_ADICIONAIS = @"<?xml version='1.0' encoding='UTF-8'?>
																			<Root>
																				<CodigoProcesso>16099</CodigoProcesso>
																				<InformacoesAdicionais>
																				</InformacoesAdicionais>
																			</Root>";
        public const string XML_RETORNO_CONSULTA_COM_DOCUMENTOS = @"<?xml version='1.0' encoding='UTF-8'?>
																	<Root>
																		<CodigoProcesso>16099</CodigoProcesso>
																		<Documentos>
																			<Element>
																				<NumeroDocumento>0234</NumeroDocumento>
																				<CodigoTipoDocumento>1</CodigoTipoDocumento>
																				<DescricaoTipoDocumento>Subsidios</DescricaoTipoDocumento>
																				<Arquivo>JVBERi0xLjcNCiW1tbW1DQoxIDAgb2JqDQo8PC9UeXBlL0NRDM0M0FBQ0VDNjVDMTY5MjJEMjM+PDYyRTlDRDA1MzhFREQzNDNBQUNFQzY1QzE2OTIyRDIzPl0gL1ByZXYgMjg4MjQvWFJlZlN0bSAyODQ3Mz4+DQpzdGFydHhyZWYNCjMwMDQxDQolJUVPRg==</Arquivo>
																				<DataDocumento>2023-06-22 19:26:55</DataDocumento>
																				<Descricao>CRLV</Descricao>
																				<Nome>CRLV.pdf</Nome>
																				<Usuario>123456</Usuario>
																			</Element>
																			<Element>
																				<NumeroDocumento>0839</NumeroDocumento>
																				<CodigoTipoDocumento>2</CodigoTipoDocumento>
																				<DescricaoTipoDocumento>Subsidios</DescricaoTipoDocumento>
																				<Arquivo>JVBERi0xLjcNCiW1tbW1DQoxIDAgb2JqDQo8PC9UeXBlL0NhdGFsb2cvUGFnZXMgMiAwIFIvTGFuZyhwdCkgL1N0cnVjdFRyZWVSb290IDE=</Arquivo>
																				<DataDocumento>2023-06-22 19:26:55</DataDocumento>
																				<Descricao>BO</Descricao>
																				<Nome>BO.pdf</Nome>
																				<Usuario>123456</Usuario>
																			</Element>
																			<Element>
																				<NumeroDocumento>1684</NumeroDocumento>
																				<CodigoTipoDocumento>3</CodigoTipoDocumento>
																				<DescricaoTipoDocumento>Subsidios</DescricaoTipoDocumento>
																				<Arquivo>JVBERi0xLjcNCixMzA1MkREMTA0RDlFQzAwNUZFN0RBNjE2QjM+XSAvUHJldiAyODUzOS9YUmVmU3RtIDI4MTgyPj4NCnN0YXJ0eHJlZg0KMjk4MzYNCiUlRU9G</Arquivo>
																				<DataDocumento>2023-06-22 19:26:55</DataDocumento>
																				<Descricao>CNH</Descricao>
																				<Nome>CNH.pdf</Nome>
																				<Usuario>123456</Usuario>
																			</Element>
																			<Element>
																				<NumeroDocumento>5430</NumeroDocumento>
																				<CodigoTipoDocumento>4</CodigoTipoDocumento>
																				<DescricaoTipoDocumento>Subsidios</DescricaoTipoDocumento>
																				<Arquivo>JVBERi0xLjcNCiWNURBNTY5OUU0NkVBRUYyPl0gL1ByZXYgMzAxNzQvWFJlZlN0bSAyOTgyMj4+DQpzdGFydHhyZWYNCjMxMzkxDQolJUVPRg==</Arquivo>
																				<DataDocumento>2023-06-22 19:26:55</DataDocumento>
																				<Descricao>CONTRATO</Descricao>
																				<Nome>CONTRATO.pdf</Nome>
																				<Usuario>123456</Usuario>
																			</Element>
																		</Documentos>
																	</Root>";
        public const string XML_RETORNO_CONSULTA_SEM_DOCUMENTOS = @"<?xml version='1.0' encoding='UTF-8'?>
																	<Root>
																		<CodigoProcesso>16099</CodigoProcesso>
																		<Documentos>
																		</Documentos>
																	</Root>";
        public const string XML_RETORNO_INCLUSAO_PROCESSO = @"<?xml version='1.0' encoding='UTF-8'?>
																<Root>
																	<CodigoStatus>200</CodigoStatus>
																	<Mensagem>Processo importado com sucesso.</Mensagem>
																	<Status>OK</Status>
																    <Informacao>16099</Informacao>
																</Root>";
        public const string XML_RETORNO_INCLUSAO_DOCUMENTO = @"<?xml version='1.0' encoding='UTF-8'?>
																<Root>
																	<CodigoStatus>200</CodigoStatus>
																	<Mensagem>Documento importado com sucesso.</Mensagem>
																	<Status>OK</Status>
																	<Informacao>52</Informacao>
																</Root>";
        public const string XML_RETORNO_INCLUSAO_INFORMACAO_ADICIONAL = @"<?xml version='1.0' encoding='UTF-8'?>
																			<Root>
																				<CodigoStatus>200</CodigoStatus>
																				<Mensagem>Informação adicional importada com sucesso.</Mensagem>
																				<Status>OK</Status>
																				<Informacao>12</Informacao>
																			</Root>";
        public const string XML_RETORNO_INCLUSAO_ANDAMENTO = @"<?xml version='1.0' encoding='UTF-8'?>
																			<Root>
																				<CodigoStatus>200</CodigoStatus>
																				<Mensagem>Andamento importado com sucesso.</Mensagem>
																				<Status>OK</Status>
																				<Informacao>Processamento de Subsídios</Informacao>
																			</Root>";
    }
}
