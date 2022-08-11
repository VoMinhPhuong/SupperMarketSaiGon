using Microsoft.AspNetCore.Mvc;

namespace SupperMarketSaiGon.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
