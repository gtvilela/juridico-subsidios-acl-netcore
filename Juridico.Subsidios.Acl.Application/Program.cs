using Juridico.Subsidios.Acl.Application;
using Juridico.Subsidios.Acl.Infrastucture;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructure();
builder.Services.AddApplication();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.EnableAnnotations();
    opt.SwaggerDoc("v1",
        new OpenApiInfo
        {
            Title = "Juridico Subs�dios ACL API",
            Description = "ACL respons�vel para fazer a comunica��o com qualquer fornecedor que forne�a o sistema de gest�o de processos judiciais. Al�m de receber as informa��es necess�rias para a busca dos subs�dios, essa aplica��o tem a responsabilidade de receber os subs�dios retornados e criar a camada de comunica��o com o fornecedor para que sejam cadastrados no processo, no sistema terceiro.",
            Version = "v1",
            Contact = new OpenApiContact()
            {
                Name = "Gabriela Vilela",
                Email = "868148@sga.pucminas.br"
            }
        });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    opt.IncludeXmlComments(xmlPath);
});


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
