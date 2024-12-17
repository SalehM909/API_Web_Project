using API_Web_Project.DTO;
using API_Web_Project.Model;

namespace API_Web_Project.Services
{
    public interface IUserService
    {
        string Login(LoginDto model);
        User Register(RegisterDto model);
        User UpdateUser(UpdateUserDto model);
    }
}