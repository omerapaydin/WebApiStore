using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;
        public ProductsController(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> GetProducts()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int? id)
        {
            return Ok();
        }
    }
}