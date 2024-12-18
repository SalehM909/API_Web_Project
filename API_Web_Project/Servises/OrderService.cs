using API_Web_Project.DTO;
using API_Web_Project.Model;
using API_Web_Project.Repositories;

namespace API_Web_Project.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepo;
        private readonly IProductRepository _productRepo;

        public OrderService(IOrderRepository orderRepo, IProductRepository productRepo)
        {
            _orderRepo = orderRepo;
            _productRepo = productRepo;
        }

        public Order PlaceOrder(OrderDto model, int userId)
        {
            // Ensure sufficient stock and calculate total amount
            decimal totalAmount = 0;
            foreach (var item in model.Items)
            {
                var product = _productRepo.GetById(item.ProductId);
                if (product == null)
                    throw new Exception($"Product {item.ProductId} not found.");

                if (product.Stock < item.Quantity)
                    throw new Exception($"Insufficient stock for {product.Name}.");

                totalAmount += product.Price * item.Quantity;
                product.Stock -= item.Quantity; // Reduce stock
            }

            // Create order
            var order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.UtcNow,
                TotalAmount = totalAmount
            };

            _orderRepo.AddOrder(order);

            // Add ordered products
            foreach (var item in model.Items)
            {
                var orderProduct = new OrderProduct
                {
                    OrderId = order.OID,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };

                _orderRepo.AddOrderProduct(orderProduct);
            }

            return order;
        }
    }

}
