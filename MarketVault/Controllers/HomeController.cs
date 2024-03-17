namespace MarketVault.Controllers
{
    using MarketVault.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;

    /// <summary>
    /// Home Controller - default controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Constructor injecting logger
        /// </summary>
        /// <param name="logger">Logger</param>
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Default action which leads to home page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}
