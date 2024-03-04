namespace MarketVault.Controllers
{
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.CounterParty;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Counter Party Controller (Authorized)
    /// </summary>
    [Authorize]
    public class CounterPartyController : Controller
    {
        /// <summary>
        /// Counter Party Service
        /// </summary>
        private readonly ICounterPartyService service = null!;

        /// <summary>
        /// Default constructor, injecting service (DI)
        /// </summary>
        /// <param name="service">ICounterPartyService</param>
        public CounterPartyController(ICounterPartyService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Default Index action
        /// </summary>
        /// <returns>IActionResult</returns>
        public IActionResult Index()
        {
            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for all counter parties in app (Asynchronous)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> All()
        {
            var serviceModels = await this.service
                .GetAllAsync();

            var viewModels = serviceModels
                .Select(sm => new CounterPartyViewModel()
                {
                    BankCode = sm.BankCode,
                    BankIBAN = sm.BankIBAN,
                    BankName = sm.Bank.Name,
                    FirmName = sm.Firm.Name,
                    Id = sm.Id,
                    Name = sm.Name,
                    ValueAddedTaxLawId = sm.ValueAddedTaxLawId,
                    VATNumber = sm.VATNumber
                })
                .ToList();

            return View(viewModels);
        }
    }
}
