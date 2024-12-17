using API_Web_Project.DTO;
using API_Web_Project.Model;
using API_Web_Project.Repositories;

namespace API_Web_Project.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;

        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public Product AddProduct(ProductDto model)
        {
            if (model.Price <= 0)
                throw new Exception("Product price must be greater than zero.");

            if (model.Stock < 0)
                throw new Exception("Stock cannot be negative.");

            var product = new Product
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                Stock = model.Stock,
                OverallRating = 0
            };

            _productRepo.AddProduct(product);
            return product;
        }
    }
}
