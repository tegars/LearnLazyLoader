using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnLazyLoader.EntityFramework;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnLazyLoader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private DBContext _context;
        public HomeController(DBContext context)
        {
            _context = context;
        }
        public IActionResult Get()
        {
            var category = _context.Categories.ToList();
            return Ok(category);
        }
    }
}