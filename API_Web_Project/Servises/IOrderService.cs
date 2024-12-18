using API_Web_Project.DTO;
using API_Web_Project.Model;

namespace API_Web_Project.Services
{
    public interface IOrderService
    {
        Order PlaceOrder(OrderDto model, int userId);
    }
}