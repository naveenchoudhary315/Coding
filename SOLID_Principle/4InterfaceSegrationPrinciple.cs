using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegrationPrinciple_Problem
{
    public interface IOrderService
    {
        void CreateOrder();
        void CancelOrder();
        void ProcessPayment();
        void RefundPayment();
        void SendNotification();
        void GenerateInvoice();
    }

    public class NotificationService : IOrderService
    {
        public void SendNotification()
        {
            Console.WriteLine("Notification sent");
        }

        public void CreateOrder() => throw new NotImplementedException();
        public void CancelOrder() => throw new NotImplementedException();
        public void ProcessPayment() => throw new NotImplementedException();
        public void RefundPayment() => throw new NotImplementedException();
        public void GenerateInvoice() => throw new NotImplementedException();
    }
}



namespace InterfaceSegrationPrinciple_Solution
{
    public interface IOrderManagement
    {
        void CreateOrder();
        void CancelOrder();
    }

    public interface IPaymentService
    {
        void ProcessPayment();
        void RefundPayment();
    }

    public interface INotificationService
    {
        void SendNotification();
    }

    public interface IInvoiceService
    {
        void GenerateInvoice();
    }

    public class OrderService : IOrderManagement
    {
        public void CreateOrder()
        {
            Console.WriteLine("Order created");
        }

        public void CancelOrder()
        {
            Console.WriteLine("Order cancelled");
        }
    }


    public class PaymentService : IPaymentService
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed");
        }

        public void RefundPayment()
        {
            Console.WriteLine("Payment refunded");
        }
    }
    public class NotificationService : INotificationService
    {
        public void SendNotification()
        {
            Console.WriteLine("Notification sent");
        }
    }
    public class InvoiceService : IInvoiceService
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("Invoice generated");
        }
    }
    public class OrderController : ControllerBase
    {
        private readonly IOrderManagement _orderService;
        private readonly IPaymentService _paymentService;
        private readonly INotificationService _notificationService;

        public OrderController(
            IOrderManagement orderService,
            IPaymentService paymentService,
            INotificationService notificationService)
        {
            _orderService = orderService;
            _paymentService = paymentService;
            _notificationService = notificationService;
        }

        [HttpPost]
        public IActionResult PlaceOrder()
        {
            _orderService.CreateOrder();
            _paymentService.ProcessPayment();
            _notificationService.SendNotification();

            return Ok();
        }
    }

}