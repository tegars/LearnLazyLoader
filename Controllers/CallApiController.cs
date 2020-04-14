using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnLazyLoader.EntityFramework;
using LearnLazyLoader.EntityFramework.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnLazyLoader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallApiController : ControllerBase
    {
        private DBContext _context;
        public CallApiController(DBContext context)
        {
            _context = context;
        }
        public IActionResult Get()
        {
            var product = new Product();
            product.Name = "Baju Adidas";
            product.Price = "350000";
            product.Colour = "Merah";
            product.CategoryId = 2;
            _context.Products.Add(product);

            var product2 = new Product();
            product2.Name = "Baju Under Armour";
            product2.Price = "450000";
            product2.Colour = "Biru";
            product2.CategoryId = 2;
            _context.Products.Add(product2);

            _context.SaveChanges();
            return Ok();
        }
    }
}