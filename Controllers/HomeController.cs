using Microsoft.AspNetCore.Mvc;
using Task_tracker_API.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System;
using Task_tracker_API.Data;

namespace Task_tracker_API.Controllers
{
    public class HomeController : Controller
    {
        private readonly TaskTrackerDbContext _context;

        public HomeController(TaskTrackerDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Query data from the Users table and pass it to the view
            var users = _context.Users.ToList();
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
