using System;
using Azure.Storage.Queues.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionAppDemo.Triggers
{
    public class QueueFunction
    {
        private readonly ILogger<QueueFunction> _logger;

        public QueueFunction(ILogger<QueueFunction> logger)
        {
            _logger = logger;
        }

        [Function(nameof(QueueFunction))]
        public void Run([Microsoft.Azure.Functions.Worker.QueueTrigger("myqueue-items", Connection = "")] QueueMessage message)
        {
            _logger.LogInformation($"C# Queue trigger function processed: {message.MessageText}");
        }


        // Queue trigger function that processes messages from a specified queue.   
        [FunctionName("QueueTriggerFunction")]
        public void QueueTriggerFunction(
            [Microsoft.Azure.Functions.Worker.QueueTrigger("my-queue-name", Connection = "AzureWebJobsStorage")] string myQueueItem,
            ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed message: {myQueueItem}");
            // Your processing logic here
        }



    }
}
