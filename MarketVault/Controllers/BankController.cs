﻿namespace MarketVault.Controllers
{
    using MarketVault.Core;
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Extensions;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.Address;
    using MarketVault.Models.Bank;
    using MarketVault.Models.Search;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using static MarketVault.Infrastructure
       .Constants.DataConstants.RoleConstants;

    /// <summary>
    /// Bank Controller (Authorized)
    /// </summary>
    public class BankController : BaseController
    {
        /// <summary>
        /// Bank Service
        /// </summary>
        private readonly IBankService service = null!;

        /// <summary>
        /// Address Service
        /// </summary>
        private readonly IAddressService addressService = null!;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<BankController> logger;

        /// <summary>
        /// Default constructor, injecting services and logger (DI)
        /// </summary>
        /// <param name="service">IBankService</param>
        /// <param name="addressService">IAddressService</param>
        /// <param name="logger">Logger</param>
        public BankController(
            ILogger<BankController> logger,
            IBankService service,
            IAddressService addressService)
        {
            this.logger = logger;
            this.service = service;
            this.addressService = addressService;
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
        /// Action for all banks in app (Asynchronous)
        /// </summary>
        /// <param name="pages">Pager pages</param>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> All(int pages = 1)
        {
            var serviceModels = await this.service
                .GetAllAsync();

            var viewModels = serviceModels
                .Select(sm => new BankViewModel()
                {
                    AddressId = sm.AddressId,
                    Id = sm.Id,
                    Name = sm.Name,
                    TownName = sm.Address.TownName,
                    StreetName = sm.Address.StreetName,
                    StreetNumber = sm.Address.StreetNumber,
                    Information = sm.Name + "-" + sm.Address.TownName.Substring(0, 3)
                    + sm.Address.StreetNumber + sm.Address.StreetName.Substring(0, 5)
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
                Controller = "Bank"
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
        /// Action for filtering banks (Asynchronous)
        /// </summary>
        /// <param name="searchSortType">Search sort type</param>
        /// <param name="searchViewName">View name for searching</param>
        /// <param name="searchQuery">Search query</param>
        /// <param name="pages">Pager pages</param>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> SearchBanks(
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
                .Select(sm => new BankViewModel()
                {
                    Id = sm.Id,
                    Name = sm.Name,
                    AddressId = sm.AddressId,
                    StreetName = sm.Address.StreetName,
                    StreetNumber = sm.Address.StreetNumber,
                    TownName = sm.Address.TownName,
                    Information = sm.Name + "-" + sm.Address.TownName.Substring(0, 3)
                    + sm.Address.StreetNumber + sm.Address.StreetName.Substring(0, 5)
                })
                .ToList();

            int recsCount = await this.service
                .GetPredicatedCountAsync(searchSortType, searchQuery);

            var pager = new Pager(recsCount, pages, pageSize)
            {
                Action = "SearchBanks",
                Controller = "Bank",
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
        /// Action for adding a bank in app (Asynchronous, GET)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Add()
        {
            var formModel = new BankFormModel()
            {
                Addresses = await this.GetAddresses()
            };

            return View(formModel);
        }

        /// <summary>
        /// Action for adding a bank in app (Asynchronous, POST)
        /// </summary>
        /// <param name="model">BankFormModel - model to add</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Add(BankFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Addresses = await this.GetAddresses();
                return View(model);
            }

            var serviceModel = new BankServiceModel()
            {
                Name = model.Name,
                AddressId = model.AddressId ?? 0
            };

            await this.service.AddAsync(serviceModel);

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for editing a bank by id in app (Asynchronous, GET)
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
                    logger.LogError("Bad request - Bank/Edit - (GET)");
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var viewModel = new BankFormModel()
                {
                    AddressId = entity.AddressId,
                    Addresses = await this.GetAddresses(),
                    Name = entity.Name,
                    Information = entity.Name + "-" + entity.Address.TownName.Substring(0, 3)
                    + entity.Address.StreetNumber + entity.Address.StreetName.Substring(0, 5)
                };

                if (details != viewModel.GetDetails())
                {
                    logger.LogError("Bad request - Bank/Edit - (GET)");
                    return BadRequest();
                }

                return View(viewModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Bank/Edit - (GET)");
                return NotFound();
            }
        }

        /// <summary>
        /// Action for editing a bank by id in app (Asynchronous, POST)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <param name="model">Form model to use</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Edit(string id, BankFormModel model)
        {
            if (model == null ||
                !int.TryParse(id, out int parsed))
            {
                logger.LogError("Bad request - Bank/Edit - (POST)");
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                model.Addresses = await this.GetAddresses();
                return View(model);
            }

            try
            {
                var entity = await this.service.GetByIdAsync(parsed);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Bank/Edit - (POST)");
                return NotFound();
            }

            var serviceModel = new BankServiceModel()
            {
                Id = parsed,
                AddressId = model.AddressId ?? 0,
                Name = model.Name
            };

            await this.service.UpdateAsync(serviceModel);

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for deleting a bank by id in app (Asynchronous, Get)
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
                    logger.LogError("Bad request - Bank/Delete - (GET)");
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var address = entity.Address;

                var viewModel = new BankDeleteFormModel()
                {
                    Id = parsed,
                    Address = $"{address.TownName} {address.StreetName} " +
                    $"{address.StreetNumber}",
                    Name = entity.Name,
                    Information = entity.Name + "-" + entity.Address.TownName.Substring(0, 3)
                    + entity.Address.StreetNumber + entity.Address.StreetName.Substring(0, 5)
                };

                if (viewModel.GetDetails() != details)
                {
                    logger.LogError("Bad request - Bank/Delete - (GET)");
                    return BadRequest();
                }

                return View(viewModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Bank/Delete - (GET)");
                return NotFound();
            }
        }

        /// <summary>
        /// Action for deleting a bank by id in app (Asynchronous, POST)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <param name="model">BankDeleteFormModel</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Delete(string id, 
            BankDeleteFormModel model)
        {
            if (model == null || !int.TryParse(id, out int parsed))
            {
                logger.LogError("Bad request - Bank/Delete - (POST)");
                return BadRequest();
            }

            try
            {
                var oldServiceModel = await this.service.GetByIdAsync(parsed);

                var serviceModel = new BankServiceModel()
                {
                    Id = parsed,
                    AddressId = oldServiceModel.AddressId,
                    Name = oldServiceModel.Name,
                };

                await this.service.DeleteAsync(serviceModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Bank/Delete - (POST)");
                return NotFound();
            }

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for bank details (Asynchronous)
        /// </summary>
        /// <param name="id">Id to use</param>
        /// <param name="details">Details</param>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> Details(string id, 
            string details)
        {
            try
            {
                if (!int.TryParse(id, out int parsed))
                {
                    logger.LogError("Bad request - Bank/Details");
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var address = entity.Address;

                var viewModel = new BankDetailsViewModel()
                {
                    Address = $"{address.TownName} {address.StreetName}" +
                    $" {address.StreetNumber}",
                    Id = entity.Id,
                    Name = entity.Name,
                    Information = entity.Name + "-" + entity.Address.TownName.Substring(0, 3)
                    + entity.Address.StreetNumber + entity.Address.StreetName.Substring(0, 5)
                };


                if (viewModel.GetDetails() != details)
                {
                    logger.LogError("Bad request - Bank/Details");
                    return BadRequest();
                }

                return View(viewModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Bank/Details");
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
        /// Private method for accessing addresses in app (used in actions)
        /// </summary>
        /// <returns>Task<IEnumerable<AddressViewModel>></returns>
        private async Task<IEnumerable<AddressViewModel>> GetAddresses()
        {
            var firmServiceModels = await this.addressService
                 .GetAllAsync();

            var firmViewModels = firmServiceModels
            .Select(asm => new AddressViewModel
            {
                Id = asm.Id,
                StreetName = asm.StreetName,
                StreetNumber = asm.StreetNumber,
                TownName = asm.TownName
            });

            return firmViewModels;
        }
    }
}
