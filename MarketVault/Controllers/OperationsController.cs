namespace MarketVault.Controllers
{
    using MarketVault.Core.Services.Interfaces;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Item Group Controller (Authorized)
    /// </summary>
    [Authorize]
    public class OperationsController : Controller
    {
        /// <summary>
        /// IOperation service
        /// </summary>
        private readonly IOperationService service;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly Logger<OperationsController> logger;

        /// <summary>
        /// Constructor injecting logger and service
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="service">IOperationService</param>
        public OperationsController(
            Logger<OperationsController> logger,
            IOperationService service)
        {

            this.logger = logger;
            this.service = service;
        }

        [Authorize(Roles = "Admin,Worker")]
        public IActionResult Index()
        {
            return View("New");
        }

        [Authorize(Roles = "Admin,Worker")]
        public IActionResult New()
        {
            return View();
        }
    }
}
