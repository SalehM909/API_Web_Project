using API_Web_Project.DTO;
using API_Web_Project.Model;

namespace OrderManagementSystem.Services
{
    public interface IUserService
    {
        User GetUser(string email, string password);
        User Register(RegisterDto model);
    }
}