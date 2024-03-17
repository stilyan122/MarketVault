﻿namespace MarketVault.Controllers
{
    using MarketVault.Core;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.Address;
    using MarketVault.Models.Firm;
    using MarketVault.Models.Search;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Counter Party Controller (Authorized)
    /// </summary>
    [Authorize]
    public class FirmController : Controller
    {
        /// <summary>
        /// Firm Service
        /// </summary>
        private readonly IFirmService service = null!;

        /// <summary>
        /// Address Service
        /// </summary>
        private readonly IAddressService addressService = null!;

        /// <summary>
        /// Default constructor, injecting services (DI)
        /// </summary>
        /// <param name="service">IFirmService</param>
        /// <param name="addressService">IAddressService</param>
        public FirmController(IFirmService service,
            IAddressService addressService)
        {
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
        /// Action for all firms in app (Asynchronous)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> All(int pages = 1)
        {
            var serviceModels = await this.service
                .GetAllAsync();

            var viewModels = serviceModels
                .Select(sm => new FirmViewModel()
                {
                    AddressId = sm.AddressId,
                    Email = sm.Email,
                    Id = sm.Id,
                    Name = sm.Name,
                    PhoneNumber = sm.PhoneNumber,
                    ResponsiblePersonName = sm.ResponsiblePersonName,
                    StreetName = sm.Address.StreetName,
                    StreetNumber = sm.Address.StreetNumber,
                    TownName = sm.Address.TownName
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
                Controller = "Firm"
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
        /// Action for filtering firms (Asynchronous)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> SearchFirms(
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
                .Select(sm => new FirmViewModel()
                {
                    Id = sm.Id,
                    Name = sm.Name,
                    AddressId = sm.AddressId,
                    Email = sm.Email,
                    PhoneNumber = sm.PhoneNumber,
                    ResponsiblePersonName = sm.ResponsiblePersonName,
                    StreetName = sm.Address.StreetName,
                    StreetNumber = sm.Address.StreetNumber,
                    TownName = sm.Address.TownName
                })
                .ToList();

            int recsCount = await this.service
                .GetPredicatedCount(searchSortType, searchQuery);

            var pager = new Pager(recsCount, pages, pageSize)
            {
                Action = "SearchFirms",
                Controller = "Firm",
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
        /// Action for adding a firm in app (Asynchronous, GET)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var formModel = new FirmFormModel()
            {
                Addresses = await this.GetAddresses()
            };

            return View(formModel);
        }

        /// <summary>
        /// Action for adding a firm in app (Asynchronous, POST)
        /// </summary>
        /// <param name="model">FirmFormModel - model to add</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        public async Task<IActionResult> Add(FirmFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Addresses = await this.GetAddresses();
                return View(model);
            }

            var serviceModel = new FirmServiceModel()
            {
                Email = model.Email,
                AddressId = model.AddressId,
                PhoneNumber = model.PhoneNumber,
                Name = model.Name,
                ResponsiblePersonName = model.ResponsiblePersonName
            };

            await this.service.AddAsync(serviceModel);

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for editing a firm by id in app (Asynchronous, GET)
        /// </summary>
        /// <param name="id">Id to use for update</param>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            try
            {
                if (!int.TryParse(id, out int parsed))
                {
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var viewModel = new FirmFormModel()
                {
                    AddressId = entity.AddressId,
                    Email = entity.Email,
                    Addresses = await this.GetAddresses(),
                    Name = entity.Name,
                    PhoneNumber = entity.PhoneNumber,
                    ResponsiblePersonName = entity.ResponsiblePersonName
                };

                return View(viewModel);
            }
            catch (ArgumentNullException)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Action for editing a firm by id in app (Asynchronous, POST)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <param name="model">Form model to use</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        public async Task<IActionResult> Edit(string id, FirmFormModel model)
        {
            if (model == null ||
                !int.TryParse(id, out int parsed))
            {
                return BadRequest();
            }

            try
            {
                var entity = await this.service.GetByIdAsync(parsed);
            }
            catch (ArgumentNullException)
            {
                return NotFound();
            }

            var serviceModel = new FirmServiceModel()
            {
                Id = parsed,
                AddressId = model.AddressId,
                Email = model.Email,
                Name = model.Name,
                PhoneNumber = model.PhoneNumber,
                ResponsiblePersonName = model.ResponsiblePersonName
            };

            await this.service.UpdateAsync(serviceModel);

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for deleting a firm by id in app (Asynchronous, Get)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        public async Task<IActionResult> DeleteGet(string id)
        {
            try
            {
                if (!int.TryParse(id, out int parsed))
                {
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var address = entity.Address;

                var viewModel = new FirmDeleteFormModel()
                {
                    Id = parsed,
                    Address = $"{address.TownName} {address.StreetName} " +
                    $"{address.StreetNumber}",
                    Email = entity.Email,
                    Name = entity.Name,
                    PhoneNumber = entity.PhoneNumber,
                    ResponsiblePersonName = entity.ResponsiblePersonName
                };

                return View("Delete", viewModel);
            }
            catch (ArgumentNullException)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// Action for deleting a firm by id in app (Asynchronous, POST)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        public async Task<IActionResult> DeletePost(string id)
        {
            if (!int.TryParse(id, out int parsed))
            {
                return BadRequest();
            }

            try
            {
                var model = await this.service.GetByIdAsync(parsed);

                var serviceModel = new FirmServiceModel()
                {
                    Id = parsed,
                    AddressId = model.AddressId,
                    Email = model.Email,
                    Name = model.Name,
                    PhoneNumber = model.PhoneNumber,
                    ResponsiblePersonName = model.ResponsiblePersonName
                };

                await this.service.DeleteAsync(serviceModel);
            }
            catch (ArgumentNullException)
            {
                return NotFound();
            }

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for checking firm details (Asynchronous)
        /// </summary>
        /// <param name="id">Id to use</param>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                if (!int.TryParse(id, out int parsed))
                {
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var address = entity.Address;

                var viewModel = new FirmDetailsViewModel()
                {
                    Address = $"{address.TownName} {address.StreetName}" +
                    $" {address.StreetNumber}",
                    Email = entity.Email,
                    Id = entity.Id,
                    Name = entity.Name,
                    PhoneNumber = entity.PhoneNumber,
                    ResponsiblePersonName = entity.ResponsiblePersonName
                };

                return View(viewModel);
            }
            catch (ArgumentNullException)
            {
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