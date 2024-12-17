using API_Web_Project.Model;

namespace API_Web_Project.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetByEmail(string email);
        User GetById(int id);
    }
}