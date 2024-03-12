namespace MarketVault.Controllers
{
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.Bank;
    using MarketVault.Models.CounterParty;
    using MarketVault.Models.Firm;
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
        /// Firm Service
        /// </summary>
        private readonly IFirmService firmService = null!;

        /// <summary>
        /// Bank Service
        /// </summary>
        private readonly IBankService bankService = null!;

        /// <summary>
        /// Default constructor, injecting services (DI)
        /// </summary>
        /// <param name="service">ICounterPartyService</param>
        /// <param name="firmService">IFirmService</param>
        /// <param name="bankService">IBankService</param>
        public CounterPartyController(ICounterPartyService service,
            IFirmService firmService,
            IBankService bankService)
        {
            this.service = service;
            this.firmService = firmService;
            this.bankService = bankService;
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

        /// <summary>
        /// Action for adding a counter party in app (Asynchronous, GET)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var formModel = new CounterPartyFormModel()
            {
                Firms = await this.GetFirms(),
                Banks = await this.GetBanks(),
            };

            return View(formModel);
        }

        /// <summary>
        /// Action for adding a counter party in app (Asynchronous, POST)
        /// </summary>
        /// <param name="model">CounterPartyFormModel - model to add</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        public async Task<IActionResult> Add(CounterPartyFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Banks = await this.GetBanks();
                model.Firms = await this.GetFirms();
                return View(model);
            }

            var serviceModel = new CounterPartyServiceModel()
            {
                Name = model.Name,
                BankCode = model.BankCode,
                BankIBAN = model.BankIBAN,
                BankId = model.BankId,
                FirmId = model.FirmId,
                ValueAddedTaxLawId = model.ValueAddedTaxLawId,
                VATNumber= model.VATNumber
            };

            await this.service.AddAsync(serviceModel);

            return RedirectToAction("All");
        }

        /// <summary>
        /// Private method for accessing banks in app (used in actions)
        /// </summary>
        /// <returns>Task<IEnumerable<BankViewModel>></returns>
        private async Task<IEnumerable<BankViewModel>> GetBanks()
        {
            var bankServiceModels = await this.bankService
                .GetAllAsync();

            var bankViewModels = bankServiceModels
                .Select(bsv => new BankViewModel
                {
                    Id = bsv.Id,
                    Name = bsv.Name,
                    AddressId = bsv.AddressId,
                    StreetName = bsv.Address.StreetName,
                    StreetNumber = bsv.Address.StreetNumber,
                    TownName = bsv.Address.TownName
                });

            return bankViewModels;
        }

        /// <summary>
        /// Private method for accessing firms in app (used in actions)
        /// </summary>
        /// <returns>Task<IEnumerable<FirmViewModel>></returns>
        private async Task<IEnumerable<FirmViewModel>> GetFirms()
        {
            var firmServiceModels = await this.firmService
                 .GetAllAsync();

            var firmViewModels = firmServiceModels
                .Select(fsm => new FirmViewModel
                {
                    Id = fsm.Id,
                    Name = fsm.Name,
                    AddressId = fsm.AddressId,
                    Email = fsm.Email,
                    PhoneNumber = fsm.PhoneNumber,
                    ResponsiblePersonName = fsm.ResponsiblePersonName,
                    StreetName = fsm.Address.StreetName,
                    StreetNumber = fsm.Address.StreetNumber,
                    TownName = fsm.Address.TownName
                });

            return firmViewModels;
        }
    }
}
