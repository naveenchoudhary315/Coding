using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_without_Abstraction
{
    public class EmailService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email Sent: {message}");
        }
    }

    public class OrderService
    {
        private readonly EmailService _emailService;

        public OrderService()
        {
            _emailService = new EmailService();
        }

        public void CreateOrder()
        {
            Console.WriteLine("Order Created");

            _emailService.Send("Order Created");
        }
    }
}



namespace Solution_with_Abstraction
{
    public interface INotificationService
    {
        void Send(string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email Sent: {message}");
        }
    }
    public class SmsNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS Sent: {message}");
        }
    }

    public class OrderService
    {
        private readonly INotificationService _notificationService;

        public OrderService(
            INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void CreateOrder()
        {
            Console.WriteLine("Order Created");

            _notificationService.Send("Order Created");
        }
    }

}