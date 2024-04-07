using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task_tracker_API.Data;
using Task_tracker_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Task_tracker_API.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/test
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API Connection Successful");
        }
    }
}