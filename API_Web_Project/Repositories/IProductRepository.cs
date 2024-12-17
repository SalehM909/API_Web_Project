using API_Web_Project.Model;

namespace API_Web_Project.Repositories
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        List<Product> GetAll();
        Product GetById(int id);
    }
}