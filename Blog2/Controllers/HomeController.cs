using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Blog2.Models;
using Microsoft.AspNetCore.Authorization;
namespace Blog2.Controllers
{
    public class HomeController : Controller
    {
        UserContext db;

        public HomeController(UserContext context)
        {
            db = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            //  Content(User.Identity.Name);
            return View(db.Posts.ToList());
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
