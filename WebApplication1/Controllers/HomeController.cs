using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext dbcontext;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext dbcontext)
        {
            _logger = logger;
            this.dbcontext=dbcontext;
        }
        //[Authorize]
        public IActionResult Index()
        {
            var items = dbcontext.classes.ToList();
            return View(items);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        /*public IActionResult Zalogowany()
        {
            var items = dbcontext.classes.ToList();
            return View(items);
        }*/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}