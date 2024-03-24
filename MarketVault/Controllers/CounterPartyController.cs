namespace MarketVault.Controllers
{
    using MarketVault.Core;
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.Bank;
    using MarketVault.Models.CounterParty;
    using MarketVault.Models.Firm;
    using MarketVault.Models.Product;
    using MarketVault.Models.Search;
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
        /// Logger
        /// </summary>
        private readonly ILogger<CounterPartyController> logger;

        /// <summary>
        /// Default constructor, injecting services and logger (DI)
        /// </summary>
        /// <param name="service">ICounterPartyService</param>
        /// <param name="firmService">IFirmService</param>
        /// <param name="bankService">IBankService</param>
        /// <param name="logger">Logger</param>
        public CounterPartyController(
            ILogger<CounterPartyController> logger,
            ICounterPartyService service,
            IFirmService firmService,
            IBankService bankService)
        {
            this.service = service;
            this.firmService = firmService;
            this.bankService = bankService;
            this.logger = logger;
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
        public async Task<IActionResult> All(int pages = 1)
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

            const int pageSize = 10;

            if (pages < 1)
            {
                pages = 1;
            }

            int recsCount = viewModels.Count;

            var pager = new Pager(recsCount, pages, pageSize)
            {
                Action = "All",
                Controller = "CounterParty"
            };

            int recsSkip = (pages - 1) * pageSize;

            var data = viewModels
                .Skip(recsSkip)
                .Take(pager.PageSize)
                .ToList();

            this.ViewBag.Pager = pager;

            return View(data);
        }

        /// <summary>
        /// Action for filtering counter parties (Asynchronous)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> SearchCounterParties(
                string searchSortType,
                string searchViewName,
                string searchQuery,
                int pages = 1)
        {
            if (IsNullOrEmptyOrWhiteSpace(searchSortType)
                || IsNullOrEmptyOrWhiteSpace(searchViewName)
                || IsNullOrEmptyOrWhiteSpace(searchQuery))
            {
                return RedirectToAction("All");
            }

            const int pageSize = 10;

            if (pages < 1)
            {
                pages = 1;
            }

            var serviceModels = await this.service
                .GetAllByPredicatePagedAsync(searchSortType,
                searchQuery,
                pageSize,
                pages);

            var viewModels = serviceModels
                .Select(sm => new CounterPartyViewModel()
                {
                    Id = sm.Id,
                    Name = sm.Name,
                    BankCode = sm.BankCode,
                    BankIBAN = sm.BankIBAN,
                    BankName = sm.Bank.Name,
                    FirmName = sm.Firm.Name,
                    ValueAddedTaxLawId = sm.ValueAddedTaxLawId,
                    VATNumber = sm.VATNumber
                })
                .ToList();

            int recsCount = await this.service
                .GetPredicatedCount(searchSortType, searchQuery);

            var pager = new Pager(recsCount, pages, pageSize)
            {
                Action = "SearchCounterParties",
                Controller = "CounterParty",
                SearchQuery = searchQuery,
                SearchSortingType = searchSortType,
                SearchViewName = searchViewName
            };

            var searcher = new SearchModel()
            {
                ViewName = searchViewName,
                SortingType = searchSortType,
                Query = searchQuery
            };

            int recsSkip = (pages - 1) * pageSize;

            this.ViewBag.Pager = pager;
            this.ViewBag.Searcher = searcher;

            return View(searchViewName, viewModels);
        }

        /// <summary>
        /// Action for adding a counter party in app (Asynchronous, GET)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        [Authorize(Roles = "Admin,Worker")]
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
        [Authorize(Roles = "Admin,Worker")]
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
        /// Action for editing a counter party by id in app (Asynchronous, GET)
        /// </summary>
        /// <param name="id">Id to use for update</param>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> Edit(string id)
        {
            try
            {
                if (!int.TryParse(id, out int parsed))
                {
                    logger.LogError("Bad request - CounterParty/Edit - (GET)");
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var viewModel = new CounterPartyFormModel()
                {
                    BankCode = entity.BankCode,
                    FirmId = entity.FirmId,
                    Firms = await this.GetFirms(),
                    BankIBAN = entity.BankIBAN,
                    BankId = entity.BankId,
                    Banks = await this.GetBanks(),
                    Name = entity.Name,
                    ValueAddedTaxLawId = entity.ValueAddedTaxLawId,
                    VATNumber = entity.VATNumber
                };

                return View(viewModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "CounterParty/Edit - (GET)");
                return NotFound();
            }
        }

        /// <summary>
        /// Action for editing a counter party by id in app (Asynchronous, POST)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <param name="model">Form model to use</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> Edit(string id, CounterPartyFormModel model)
        {
            if (model == null ||
                !int.TryParse(id, out int parsed))
            {
                logger.LogError("Bad request - CounterParty/Edit - (POST)");
                return BadRequest();
            }

            try
            {
                var entity = await this.service.GetByIdAsync(parsed);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "CounterParty/Edit - (POST)");
                return NotFound();
            }

            var serviceModel = new CounterPartyServiceModel()
            {
                Id = parsed,
                BankId = model.BankId,
                BankCode = model.BankCode,
                BankIBAN = model.BankIBAN,
                FirmId = model.FirmId,
                Name = model.Name,
                ValueAddedTaxLawId = model.ValueAddedTaxLawId,
                VATNumber = model.VATNumber
            };

            await this.service.UpdateAsync(serviceModel);

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for deleting a counter party by id in app (Asynchronous, Get)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> DeleteGet(string id)
        {
            try
            {
                if (!int.TryParse(id, out int parsed))
                { 
                    logger.LogError("Bad request - CounterParty/Delete - (GET)");
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var bankAddress = entity.Bank.Address;
                var firmAddress = entity.Firm.Address;

                var viewModel = new CounterPartyDeleteFormModel()
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    BankAddress = $"{bankAddress.TownName} {bankAddress.StreetName} " +
                    $"{bankAddress.StreetNumber}",
                    FirmAddress = $"{firmAddress.TownName} {firmAddress.StreetName} " +
                    $"{firmAddress.StreetNumber}",
                    BankCode = entity.BankCode,
                    BankIBAN = entity.BankIBAN,
                    ValueAddedTaxLawId = entity.ValueAddedTaxLawId,
                    VATNumber = entity.VATNumber,
                    BankName = entity.Bank.Name
                };

                return View("Delete", viewModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "CounterParty/Delete - (GET)");
                return NotFound();
            }
        }

        /// <summary>
        /// Action for deleting a product by id in app (Asynchronous, POST)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> DeletePost(string id)
        {
            if (!int.TryParse(id, out int parsed))
            {
                logger.LogError("Bad request - CounterParty/Delete - (POST)");
                return BadRequest();
            }

            try
            {
                var model = await this.service.GetByIdAsync(parsed);

                var serviceModel = new CounterPartyServiceModel()
                {
                    Id = parsed,
                    BankCode = model.BankCode,
                    FirmId = model.FirmId,
                    BankId = model.BankId,
                    BankIBAN = model.BankIBAN,
                    VATNumber = model.VATNumber,
                    ValueAddedTaxLawId = model.ValueAddedTaxLawId
                };

                await this.service.DeleteAsync(serviceModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "CounterParty/Delete - (POST)");
                return NotFound();
            }

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for checking counter party details (Asynchronous)
        /// </summary>
        /// <param name="id">Id to use</param>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                if (!int.TryParse(id, out int parsed))
                {
                    logger.LogError("Bad request - CounterParty/Details");
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var bankAddress = entity.Bank.Address;
                var firmAddress = entity.Firm.Address;

                var viewModel = new CounterPartyDetailsViewModel()
                {
                    BankCode = entity.BankCode,
                    BankIBAN = entity.BankIBAN,
                    BankName = entity.Bank.Name,
                    FirmEmail = entity.Firm.Email,
                    FirmName = entity.Firm.Name,
                    FirmPhoneNumber = entity.Firm.PhoneNumber,
                    FirmResponsiblePersonName = entity.Firm.ResponsiblePersonName,
                    Id = entity.Id,
                    Name = entity.Name,
                    FirmAddress = $"{firmAddress.TownName} {firmAddress.StreetName} " +
                    $"{firmAddress.StreetNumber}",
                    BankAddress = $"{bankAddress.TownName} {bankAddress.StreetName} " +
                    $"{bankAddress.StreetNumber}",
                    ValueAddedTaxLawId = entity.ValueAddedTaxLawId,
                    VATNumber = entity.VATNumber
                };

                return View(viewModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "CounterParty/Details");
                return NotFound();
            }
        }

        /// <summary>
        /// Private help method to determine whether a string is null, whitespace or empty
        /// </summary>
        /// <param name="value">Value to check</param>
        /// <returns>bool</returns>
        private static bool IsNullOrEmptyOrWhiteSpace(string value)
        {
            return value == null ||
              String.IsNullOrEmpty(value) ||
              String.IsNullOrWhiteSpace(value);
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
