using Microsoft.AspNetCore.Mvc;

namespace MarketVault.Controllers
{
    public class OperationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
