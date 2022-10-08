using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Phloem.Core.Interfaces.Repository;
using Phloem.Core.Model.DTOs;
using System.Collections.Generic;

namespace Phloem.API.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            IEnumerable<ProductDTO> products = await _productRepository.GetProducts();

            return products == null ? NotFound() : Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProduct(int id)
        {
            ProductDTO product = await _productRepository.GetProduct(id);

            return product == null ? NotFound() : Ok(product);
        }
    }
}
