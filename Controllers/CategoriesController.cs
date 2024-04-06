using Microsoft.AspNetCore.Mvc;
using Task_tracker_API.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task_tracker_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly TaskTrackerDbContext _context;

        public CategoriesController(TaskTrackerDbContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        // Additional actions (POST, PUT, DELETE) can be implemented here
    }
}