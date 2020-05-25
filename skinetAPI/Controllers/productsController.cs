using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastucture.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using skinetAPI.Data;

namespace skinetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class productsController : ControllerBase
    {
        private readonly TuckShopContext _context;
        public productsController(TuckShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> getProducts()
        {
            var products = await _context.Products.ToListAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> getProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}