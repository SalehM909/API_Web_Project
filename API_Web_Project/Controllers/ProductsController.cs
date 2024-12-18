﻿using Microsoft.AspNetCore.Mvc;
using API_Web_Project.DTO;
using API_Web_Project.Services;

namespace API_Web_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductDto model)
        {
            try
            {
                var product = _productService.AddProduct(model);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("search")]
        public IActionResult GetProducts([FromQuery] ProductFilterDto filter)
        {
            try
            {
                var products = _productService.GetFilteredProducts(
                    filter.Name, filter.MinPrice, filter.MaxPrice, filter.Page, filter.PageSize);
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] ProductDto model)
        {
            try
            {
                // Ensure the product exists before updating
                var existingProduct = _productService.GetProductById(id);
                if (existingProduct == null)
                {
                    return NotFound($"Product with ID {id} not found.");
                }

                var updatedProduct = _productService.UpdateProduct(id, model);
                return Ok(updatedProduct);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
