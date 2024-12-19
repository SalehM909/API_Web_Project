using API_Web_Project.Controllers;
using API_Web_Project.DTO;
using API_Web_Project.Model;
using API_Web_Project.Repositories;
using API_Web_Project.Services;
using OrderManagementSystem.Services;

namespace API_Web_Project.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepo;
        private readonly IConfiguration _configuration;
        public UserService(IUserRepository userRepo, IConfiguration configuration)
        {
            _userRepo = userRepo;
            _configuration = configuration;
        }
        public User Register(RegisterDto model)
        {
            var existingUser = _userRepo.GetByEmail(model.Email);
            if (existingUser != null)
            {
                throw new Exception("Email is already registered.");
            }
            var user = new User
            {
                Name = model.Name,
                Email = model.Email,
                Password = model.Password,
                Phone = model.Phone,
                Role = model.Role,
                CreatedAt = DateTime.UtcNow,
            };
            _userRepo.AddUser(user);
            return user;
        }


        public User GetUser(string email, string password)
        {
            return _userRepo.GetUser(email, password);

        }
    }
}
