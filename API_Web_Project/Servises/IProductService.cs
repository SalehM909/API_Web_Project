using API_Web_Project.DTO;
using API_Web_Project.Model;

namespace API_Web_Project.Services
{
    public interface IProductService
    {
        Product AddProduct(ProductDto model);
        List<Product> GetFilteredProducts(string name, decimal minPrice, decimal maxPrice, int page, int pageSize);
        Product GetProductById(int id);
        Product UpdateProduct(int id, ProductDto model);
    }
}