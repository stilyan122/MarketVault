namespace MarketVault.Controllers
{
    using MarketVault.Core;
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Extensions;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.Address;
    using MarketVault.Models.Search;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using static MarketVault.Infrastructure
        .Constants.DataConstants.RoleConstants;

    /// <summary>
    /// Address Controller (Authorized)
    /// </summary>
    public class AddressController : BaseController
    {
        /// <summary>
        /// Address Service
        /// </summary>
        private readonly IAddressService service = null!;

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
        private readonly ILogger<AddressController> logger;

        /// <summary>
        /// Default constructor, injecting services and logger (DI)
        /// </summary>
        /// <param name="service">IAddressService</param>
        /// <param name="firmService">IFirmService</param>
        /// <param name="bankService">IBankService</param>
        /// <param name="logger">Logger</param>
        public AddressController(
            ILogger<AddressController> logger,
            IAddressService service,
            IFirmService firmService,
            IBankService bankService)
        {
            this.logger = logger;
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
        /// Action for all addresses in app (Asynchronous)
        /// </summary>
        /// <param name="pages">Pager pages</param>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> All(int pages = 1)
        {
            var serviceModels = await this.service
                .GetAllAsync();

            var viewModels = serviceModels
                .Select(sm => new AddressViewModel()
                {
                    Id = sm.Id,
                    StreetName = sm.StreetName,
                    StreetNumber = sm.StreetNumber,
                    TownName = sm.TownName,
                    Information = sm.StreetName.Substring(0, 3) + " " +
                    sm.StreetNumber + sm.TownName.Substring(0, 4)
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
                Controller = "Address"
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
        /// Action for filtering addresses (Asynchronous)
        /// </summary>
        /// <param name="searchSortType">Search sort type</param>
        /// <param name="searchViewName">View name for search</param>
        /// <param name="searchQuery">Search query</param>
        /// <param name="pages">Pager pages</param>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> SearchAddresses(
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
                .Select(sm => new AddressViewModel()
                {
                    Id = sm.Id,
                    StreetName = sm.StreetName,
                    StreetNumber = sm.StreetNumber,
                    TownName = sm.TownName,
                    Information = sm.StreetName.Substring(0, 3) + " " +
                    sm.StreetNumber + sm.TownName.Substring(0, 4)
                })
                .ToList();

            int recsCount = await this.service
                .GetPredicatedCountAsync(searchSortType, searchQuery);

            var pager = new Pager(recsCount, pages, pageSize)
            {
                Action = "SearchAddresses",
                Controller = "Address",
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
        /// Action for adding an address in app (GET)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public IActionResult Add()
        {
            var formModel = new AddressFormModel()
            {
            };

            return View(formModel);
        }

        /// <summary>
        /// Action for adding an address in app (Asynchronous, POST)
        /// </summary>
        /// <param name="model">AddressFormModel - model to add</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Add(AddressFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var serviceModel = new AddressServiceModel()
            {
                StreetName = model.StreetName,
                StreetNumber = model.StreetNumber,
                TownName = model.TownName
            };

            await this.service.AddAsync(serviceModel);

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for editing an address by id in app (Asynchronous, GET)
        /// </summary>
        /// <param name="id">Id to use for update</param>
        /// <param name="details">Details</param>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Edit(string id, string details)
        {
            try
            {
                if (!int.TryParse(id, out int parsed))
                {
                    logger.LogError("Bad request - Address/Edit - (GET)");
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var viewModel = new AddressFormModel()
                {
                    StreetName = entity.StreetName,
                    StreetNumber = entity.StreetNumber,
                    TownName = entity.TownName,
                    Information = entity.StreetName.Substring(0, 3) + " " +
                    entity.StreetNumber + entity.TownName.Substring(0, 4)
                };

                if (viewModel.GetDetails() != details)
                {
                    logger.LogError("Bad request - Address/Edit - (GET)");
                    return BadRequest();
                }

                return View(viewModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Address/Edit - (GET)");
                return NotFound();
            }
        }

        /// <summary>
        /// Action for editing an address by id in app (Asynchronous, POST)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <param name="model">Form model to use</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Edit(string id, AddressFormModel model)
        {
            if (model == null ||
                !int.TryParse(id, out int parsed))
            {
                logger.LogError("Bad request - Address/Edit - (POST)");
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                var entity = await this.service.GetByIdAsync(parsed);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Address/Edit - (POST)");
                return NotFound();
            }

            var serviceModel = new AddressServiceModel()
            {
                Id = parsed,
                StreetName = model.StreetName,
                TownName = model.TownName,
                StreetNumber = model.StreetNumber
            };

            await this.service.UpdateAsync(serviceModel);

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for deleting an address by id in app (Asynchronous, Get)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <param name="details">Details</param>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Delete(string id, string details)
        {
            try
            {
                if (!int.TryParse(id, out int parsed))
                {
                    logger.LogError("Bad request - Address/Delete - (GET)");
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var viewModel = new AddressDeleteFormModel()
                {
                    Id = parsed,
                    StreetName = entity.StreetName,
                    StreetNumber = entity.StreetNumber,
                    TownName = entity.TownName,
                    Information = entity.StreetName.Substring(0, 3) + " " +
                    entity.StreetNumber + entity.TownName.Substring(0, 4)
                };

                if (viewModel.GetDetails() != details)
                {
                    logger.LogError("Bad request - Address/Delete - (GET)");
                    return BadRequest();
                }

                return View("Delete", viewModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Address/Delete - (GET)");
                return NotFound();
            }
        }

        /// <summary>
        /// Action for deleting an address by id in app (Asynchronous, POST)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <param name="model">AddressDeleteFormModel</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Delete(string id, 
            AddressDeleteFormModel model)
        {
            if (model == null || !int.TryParse(id, out int parsed))
            {
                logger.LogError("Bad request - Address/Delete - (POST)");
                return BadRequest();
            }

            try
            {
                var oldServiceModel = await this.service.GetByIdAsync(parsed);

                var serviceModel = new AddressServiceModel()
                {
                    Id = parsed,
                    StreetName = oldServiceModel.StreetName,
                    StreetNumber= oldServiceModel.StreetNumber,
                    TownName = oldServiceModel.TownName
                };

                await this.service.DeleteAsync(serviceModel);

                var firms = await this.firmService.GetAllAsync();
                var banks = await this.bankService.GetAllAsync();

                await this.firmService.DeleteRangeAsync(firms.Where(f => f.AddressId == parsed));
                await this.bankService.DeleteRangeAsync(banks.Where(b => b.AddressId == parsed));
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Address/Delete - (POST)");
                return NotFound();
            }

            return RedirectToAction("All");
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
    }
}
