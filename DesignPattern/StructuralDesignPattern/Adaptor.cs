using ProblemWithoutAdaptor;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemWithoutAdaptor
{

    class MainClass
    {
        void MainMethod()
        {
            // Notification n = new Notification(new ThirdPartySms()); 
        }
    }

    public interface IMessageService
    {
        void Send(string message);
    }

    public class Notification
    {
        private readonly IMessageService _messageService;
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void Notify()
        {
            _messageService.Send("Hello User");
        }
    }


    // New Problem
    // Now company purchased a third-party SMS provider library.
    // But its method signature is different.
    public class ThirdPartySms
    {
        public void SendSms(string text)
        {
            Console.WriteLine($"SMS Sent: {text}");
        }
    }
}


namespace SolutionWithAdaptor
{
    public interface IMessageService
    {
        void Send(string message);
    }

    public class Notification
    {
        private readonly IMessageService _messageService;
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }
        public void Notify()
        {
            _messageService.Send("Hello User");
        }
    }

    public class ThirdPartySms
    {
        public void SendSms(string text)
        {
            Console.WriteLine($"SMS Sent: {text}");
        }
    }

    //  Solving problem with Adaptor desing pattern.
    public class SmsAdapter : IMessageService
    {
        private readonly ThirdPartySms _thirdPartySms;

        public SmsAdapter(ThirdPartySms thirdPartySms)
        {
            _thirdPartySms = thirdPartySms;
        }

        public void Send(string message)
        {
            _thirdPartySms.SendSms(message);
        }
    }

    class Program
    {
        static void MainMethod()
        {
            IMessageService messageService = new SmsAdapter(new ThirdPartySms());

            Notification notification = new Notification(messageService);

            notification.Notify();
        }
    }
}
