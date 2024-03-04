using Microsoft.AspNetCore.Mvc;

namespace final_portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
