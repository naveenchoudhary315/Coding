using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Without_Factory
{
    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }

    class MainClass
    {
        public void Main()
        {
            string type = "Email";

            INotification notification;

            if (type == "Email")
            {
                notification = new EmailNotification();
            }
            else
            {
                notification = new SmsNotification();
            }

            notification.Send("Hello");

        }
    }
}

namespace Solution_With_Factory
{

    public interface INotification
    {
        void Send(string message);
    }

    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }

    class MainClass
    {
        public void Main()
        {
            string type = "Email";

            INotification notification;

            //if (type == "Email")
            //{
            //    notification = new EmailNotification();
            //}
            //else
            //{
            //    notification = new SmsNotification();
            //}

            notification = NotificationFactory.Create(type);

            notification.Send("Hello");

        }
    }

    public static class NotificationFactory
    {
        public static INotification Create(string type)
        {
            return type switch
            {
                "Email" => new EmailNotification(),
                "SMS" => new SmsNotification(),
                _ => throw new ArgumentException("Invalid type")
            };
        }
    }
}