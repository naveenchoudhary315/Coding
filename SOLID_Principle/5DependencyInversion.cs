using InterfaceSegrationPrinciple_Solution;
using SingleResponsibiltyPrinciple_Solution;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple_Problem
{
    public class OrderService
    {
        private readonly PaymentService _paymentService = new PaymentService();
        private readonly EmailService _emailService = new EmailService();

        public void PlaceOrder()
        {
            _paymentService.ProcessPayment();
            _emailService.Send("");
        }
    }
}


namespace DependencyInversionPrinciple_Solution
{
    public interface IPaymentService
    {
        void ProcessPayment();
    }

    public interface IEmailService
    {
        void SendEmail();
    }
    public class PaymentService : IPaymentService
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed");
        }
    }

    public class EmailService : IEmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("Email sent");
        }
    }


    public class OrderService
    {
        private readonly IPaymentService _paymentService;
        private readonly IEmailService _emailService;

        public OrderService(IPaymentService paymentService, IEmailService emailService)
        {
            _paymentService = paymentService;
            _emailService = emailService;
        }

        public void PlaceOrder()
        {
            _paymentService.ProcessPayment();
            _emailService.SendEmail();
        }
    }

}