using Azure.Identity;
using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceBusQueue
{
    
    class ServiceBusQueue
    {
        // Change this for your environment
        private const string QueueName = "myqueue";

        // For Connection String auth
        private const string ServiceBusConnectionString = "<SERVICE_BUS_CONNECTION_STRING>";

        // For Managed Identity auth
        private const string FullyQualifiedNamespace = "<namespace>.servicebus.windows.net";

        public async Task MainMethod(string[] args)
        {
            Console.WriteLine("Choose authentication method:");
            Console.WriteLine("1. Connection String");
            Console.WriteLine("2. Managed Identity");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                await RunWithConnectionString();
            }
            else if (choice == "2")
            {
                await RunWithManagedIdentity();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        private static async Task RunWithConnectionString()
        {
            await using var client = new ServiceBusClient(ServiceBusConnectionString);

            await SendMessageAsync(client, "Hello from Connection String!");
            await ReceiveMessageAsync(client);
        }

        private static async Task RunWithManagedIdentity()
        {
            var credential = new DefaultAzureCredential();
            await using var client = new ServiceBusClient(FullyQualifiedNamespace, credential);

            await SendMessageAsync(client, "Hello from Managed Identity!");
            await ReceiveMessageAsync(client);
        }

        private static async Task SendMessageAsync(ServiceBusClient client, string messageText)
        {
            var sender = client.CreateSender(QueueName);
            var message = new ServiceBusMessage(messageText);
            await sender.SendMessageAsync(message);
            Console.WriteLine($"Sent: {messageText}");
        }

        private static async Task ReceiveMessageAsync(ServiceBusClient client)
        {
            var receiver = client.CreateReceiver(QueueName);
            var message = await receiver.ReceiveMessageAsync();

            if (message != null)
            {
                Console.WriteLine($"Received: {message.Body}");
                await receiver.CompleteMessageAsync(message);
            }
            else
            {
                Console.WriteLine("No message available.");
            }
        }
    }

}
