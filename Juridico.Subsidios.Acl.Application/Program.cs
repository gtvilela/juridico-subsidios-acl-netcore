using ConfigCat.Client;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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
var client = ConfigCatClient.Get(Environment.GetEnvironmentVariable("CHAVE_CONFIGCAT")); // <-- This is the actual SDK Key for your 'Test Environment' environment
client.LogLevel = ConfigCat.Client.LogLevel.Info;
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
