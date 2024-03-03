using Microsoft.AspNetCore.Mvc;

namespace MarketVault.Controllers
{
    public class CounterPartyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
