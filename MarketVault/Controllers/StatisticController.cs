namespace MarketVault.Controllers
{
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.Statistic;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Statistic controller
    /// </summary>
    public class StatisticController : Controller
    {
        /// <summary>
        /// Statistic service
        /// </summary>
        private readonly IStatisticService service;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<StatisticController> logger;

        /// <summary>
        /// Default constructor, injection of service and logger (DI)
        /// </summary>
        /// <param name="service">IStatisticService</param>
        /// <param name="logger">Logger</param>
        public StatisticController(
            IStatisticService service, 
            ILogger<StatisticController> logger)
        {
            this.service = service;
            this.logger = logger;
        }

        /// <summary>
        /// Default index method
        /// </summary>
        /// <returns>IActionResult</returns>
        public IActionResult Index()
        {
            return RedirectToAction("Statistics");
        }

        /// <summary>
        /// Get statistics method
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> Statistics()
        {
            var serviceModel = await this.service.GetStatisticServiceModelAsync();

            var viewModel = new StatisticViewModel()
            {
                TotalAddresses = serviceModel.TotalAddresses,
                TotalBanks = serviceModel.TotalBanks,
                TotalFirms = serviceModel.TotalFirms,
                TotalItemGroups = serviceModel.TotalItemGroups,
                TotalProducts = serviceModel.TotalProducts,
                TotalUsers = serviceModel.TotalUsers
            };

            return View(viewModel);
        }
    }
}
