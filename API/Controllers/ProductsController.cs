using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _repo;

        public ProductsController(IProductRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProdcuts()
        {
            var products = await _repo.GetProductsAsync();
            return Ok(products);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProdcut(int id)
        {
            var product = await _repo.GetProductByIdAsync(id);
            return Ok(product);
        }


        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProdcutBrands()
        {
            var products = await _repo.GetProductBrandsAsync();
            return Ok(products);
        }

        [HttpGet("types")]
        public async Task<ActionResult<List<Product>>> GetProdcutTypes()
        {
            var products = await _repo.GetProductTypesAsync();
            return Ok(products);
        }



    }
}