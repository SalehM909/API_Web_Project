using API_Web_Project.Model;

namespace API_Web_Project.Repositories
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        void AddOrderProduct(OrderProduct orderProduct);
        Order GetById(int id);
        List<Order> GetByUserId(int userId);
    }
}