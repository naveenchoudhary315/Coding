
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjectionWithAddKeyedService
{
    public interface IMessageService
    {
        void Send();
    }
    public class EmailService : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("Email Sent");
        }
    }
    public class SmsService : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("SMS Sent");
        }
    }

    class Program
    {

        void RegisterServices()
        {
            //var builder = new ContainerBuilder();

            //builder.Services.AddKeyedTransient<IMessageService, EmailService>("email");
            //builder.Services.AddKeyedTransient<IMessageService, SmsService>("sms");
        }
    }

    class NotificationManager
    {
        private readonly IMessageService _messageService;

        public NotificationManager([FromKeyedServices("sms")] IMessageService messageService)
        {
            _messageService = messageService;
        }
    }
}

