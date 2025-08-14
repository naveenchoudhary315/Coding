using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;
using Azure.Messaging.EventGrid;
using System.Reflection.Metadata;
using System.Configuration;

namespace FunctionAppDemo.Triggers
{
    public class HTTPTriggerFunction
    {
        private readonly ILogger<HTTPTriggerFunction> _logger;

        public HTTPTriggerFunction(ILogger<HTTPTriggerFunction> logger)
        {
            _logger = logger;
        }

        // HTTP trigger function that responds to GET and POST requests.
        [Function("Function101")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
          
       
       
        // Event Grid trigger function that processes events from Event Grid.

        [FunctionName("EventGridTriggerFunction")]
        public void EventGridTriggerFunction(
            [EventGridTrigger] EventGridEvent eventGridEvent,
            ILogger log)
        {
            log.LogInformation($"C# Event Grid trigger function processed event: {eventGridEvent.EventType}");
            // Your processing logic here
        }

        // Cosmos DB trigger function that processes changes in a specified Cosmos DB collection.

        [FunctionName("CosmosDBTriggerFunction")]
        public void CosmosDBTriggerFunction(
            [CosmosDBTrigger(
                databaseName: "my-database",
                containerName: "my-collection",
                Connection = "CosmosDBConnection",
                LeaseContainerName = "leases")]
            IReadOnlyList<Document> documents,
            ILogger log)
        {
            if (documents != null && documents.Count > 0)
            {
                log.LogInformation($"C# Cosmos DB trigger function processed {documents.Count} documents.");
                // Your processing logic here
            }
        }


        //#region HTTP Trigger Functions
        //// HTTP trigger function that responds to GET requests with a greeting message.
        //[FunctionName("HttpTriggerFunction")]

        //public IActionResult HttpTriggerFunction(
        //    [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
        //    ILogger log)
        //{
        //    log.LogInformation("C# HTTP trigger function processed a request.");
        //    return new OkObjectResult("Hello from Azure Functions!");
        //}

        //// HTTP trigger function that responds to POST requests with a greeting message.
        //[FunctionName("HttpPostTriggerFunction")]
        //public IActionResult HttpPostTriggerFunction(
        //    [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
        //    ILogger log)
        //{
        //    log.LogInformation("C# HTTP POST trigger function processed a request.");
        //    return new OkObjectResult("Hello from Azure Functions via POST!");
        //}

        //// HTTP trigger function that responds to PUT requests with a greeting message. 
        //[FunctionName("HttpPutTriggerFunction")]    
        //public IActionResult HttpPutTriggerFunction(
        //    [HttpTrigger(AuthorizationLevel.Function, "put", Route = null)] HttpRequest req,
        //    ILogger log)
        //{
        //    log.LogInformation("C# HTTP PUT trigger function processed a request.");
        //    return new OkObjectResult("Hello from Azure Functions via PUT!");
        //}

        //// HTTP trigger function that responds to DELETE requests with a greeting message.
        //[FunctionName("HttpDeleteTriggerFunction")]
        //public IActionResult HttpDeleteTriggerFunction(
        //    [HttpTrigger(AuthorizationLevel.Function, "delete", Route = null)] HttpRequest req,
        //    ILogger log)
        //{
        //    log.LogInformation("C# HTTP DELETE trigger function processed a request.");
        //    return new OkObjectResult("Hello from Azure Functions via DELETE!");
        //}

        //// HTTP trigger function that responds to PATCH requests with a greeting message.
        //[FunctionName("HttpPatchTriggerFunction")]  
        //public IActionResult HttpPatchTriggerFunction(
        //    [HttpTrigger(AuthorizationLevel.Function, "patch", Route = null)] HttpRequest req,
        //    ILogger log)
        //{
        //    log.LogInformation("C# HTTP PATCH trigger function processed a request.");
        //    return new OkObjectResult("Hello from Azure Functions via PATCH!");
        //}

        //// HTTP trigger function that responds to OPTIONS requests with a greeting message.
        //[FunctionName("HttpOptionsTriggerFunction")]
        //public IActionResult HttpOptionsTriggerFunction(
        //    [HttpTrigger(AuthorizationLevel.Function, "options", Route = null)] HttpRequest req,
        //    ILogger log)
        //{
        //    log.LogInformation("C# HTTP OPTIONS trigger function processed a request.");
        //    return new OkObjectResult("Hello from Azure Functions via OPTIONS!");
        //}

        //#endregion
    }
}
