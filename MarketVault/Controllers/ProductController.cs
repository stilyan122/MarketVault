using Microsoft.AspNetCore.Mvc;

namespace MarketVault.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
