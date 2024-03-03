using Microsoft.AspNetCore.Mvc;

namespace MarketVault.Controllers
{
    public class ItemGroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
