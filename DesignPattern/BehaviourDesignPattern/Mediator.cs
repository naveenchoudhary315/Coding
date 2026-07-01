using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Problem_Without_Mediator
{

    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder()
        {
            _orderService.CreateOrder(0, 1);

            return Ok();
        }
    }

    public class OrderService
    {
        private readonly InventoryService _inventory;
        private readonly PaymentService _payment;
        private readonly NotificationService _notification;
        private readonly ShippingService _shipping;

        public OrderService(InventoryService inventory, PaymentService payment, NotificationService notification, ShippingService shipping)
        {
            _inventory = inventory;
            _payment = payment;
            _notification = notification;
            _shipping = shipping;
        }

        public async void CreateOrder(int productId, int quantity)
        {
            _inventory.ReduceStock(productId, quantity);

            _payment.ProcessPayment();

            _shipping.CreateShipment();

            _notification.SendEmail("Order Placed");
        }
    }

    public class NotificationService
    { public void SendEmail(string input) { } }

    public class ShippingService
    {
        public void CreateShipment() { }

    }
    public class PaymentService
    {
        public void ProcessPayment() { }
    }

    public class InventoryService
    {
        public void ReduceStock(int input, int input2) { }
    }
}

namespace Solution_With_Mediator
{
    public record CreateOrderCommand(string ProductName, int Quantity) : IRequest<bool>;


    public class CreateOrderHandler : IRequestHandler<CreateOrderCommand, bool>
    {
        public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Creating Order");

            return true;
        }
    }


    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            await _mediator.Send(
                new CreateOrderCommand("Laptop", 1));

            return Ok();
        }
    }
}



