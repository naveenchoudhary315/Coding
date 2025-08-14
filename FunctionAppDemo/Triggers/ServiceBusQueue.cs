using System;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using ServiceBusTriggerAttribute = Microsoft.Azure.Functions.Worker.ServiceBusTriggerAttribute;

namespace FunctionAppDemo.Triggers
{
    public class ServiceBusQueue
    {
        private readonly ILogger<ServiceBusQueue> _logger;

        public ServiceBusQueue(ILogger<ServiceBusQueue> logger)
        {
            _logger = logger;
        }

        [Function(nameof(ServiceBusQueue))]
        public async Task Run(
            [ServiceBusTrigger("myqueue", Connection = "")]
            ServiceBusReceivedMessage message,
            ServiceBusMessageActions messageActions)
        {
            _logger.LogInformation("Message ID: {id}", message.MessageId);
            _logger.LogInformation("Message Body: {body}", message.Body);
            _logger.LogInformation("Message Content-Type: {contentType}", message.ContentType);

            // Complete the message
            await messageActions.CompleteMessageAsync(message);
        }
    }
}
