using Juridico.Subsidios.Acl.Domain.Interfaces.Services;
using Juridico.Subsidios.Acl.Domain.Models;
using RabbitMQ.Client;
using System.Text;
using System.Text.Json;

namespace Juridico.Subsidios.Acl.Infrastucture.Services
{
    public class RabbitMqService : IRabbitMqService
    {

        public void Publish(SubsidioRetornoModel subsidio, string fila)
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost", // Endereço do servidor RabbitMQ
                Port = 5672,            // Porta padrão
                UserName = "admin",     // Nome de usuário
                Password = "pwd123"      // Senha
            };

            using var connection = factory.CreateConnection();

            using var channel = connection.CreateModel();
            // Declare uma fila
            channel.QueueDeclare(fila, false, false, false, null);
            var msg = JsonSerializer.Serialize(subsidio);
            var messageBytes = Encoding.UTF8.GetBytes(msg);

            // Envie a mensagem para a fila
            channel.BasicPublish("", fila, null, messageBytes);

            Console.WriteLine("Mensagem enviada: " + messageBytes);

        }
    }
}
