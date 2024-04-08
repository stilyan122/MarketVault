namespace MarketVault.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Admin controller class
    /// </summary>
    public class AdminController : AdminBaseController
    {
        /// <summary>
        /// Index method
        /// </summary>
        /// <returns>IActionResult</returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
