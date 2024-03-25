namespace MarketVault.Controllers
{
    using MarketVault.Core;
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.ItemGroup;
    using MarketVault.Models.Measure;
    using MarketVault.Models.Product;
    using MarketVault.Models.Search;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System;

    /// <summary>
    /// Product Controller (Authorized)
    /// </summary>
    [Authorize]
    public class ProductController : Controller
    {
        /// <summary>
        /// Product Service
        /// </summary>
        private readonly IProductService service = null!;

        /// <summary>
        /// Item Group Service
        /// </summary>
        private readonly IItemGroupService itemGroupService = null!;

        /// <summary>
        /// Measure Service
        /// </summary>
        private readonly IMeasureService measureService = null!;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<ProductController> logger;

        /// <summary>
        /// Default constructor, injecting services and logger (DI)
        /// </summary>
        /// <param name="service">IProductService</param>
        /// <param name="itemGroupService">IItemGroupService</param>
        /// <param name="measureService">IMeasureService</param>
        /// <param name="logger">Logger</param>
        public ProductController(
            ILogger<ProductController> logger,
            IProductService service,
            IItemGroupService itemGroupService,
            IMeasureService measureService)
        {
            this.service = service;
            this.itemGroupService = itemGroupService;
            this.measureService = measureService;
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
        /// Action for all products in app (Asynchronous)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> All(int pages = 1)
        {
            var serviceModels = await this.service
                .GetAllAsync();

            var viewModels = serviceModels
                .Select(sm => new ProductViewModel()
            {
                Id = sm.Id,
                DateAdded = sm.DateAdded,
                CashRegisterName = sm.CashRegisterName,
                DateModified = sm.DateModified,
                CodeForScales = sm.CodeForScales,
                ItemGroupName = sm.ItemGroup.Name,
                Measure = sm.Measure.Name,
                Name = sm.Name,
                PurchasePrice = sm.PurchasePrice,
                Quantity = sm.Quantity,
                SalePrice = sm.SalePrice
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
                Controller = "Product"
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
        /// Action for filtering products (Asynchronous)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> SearchProducts(
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
                .Select(sm => new ProductViewModel()
                {
                    Id = sm.Id,
                    DateAdded = sm.DateAdded,
                    CashRegisterName = sm.CashRegisterName,
                    DateModified = sm.DateModified,
                    CodeForScales = sm.CodeForScales,
                    ItemGroupName = sm.ItemGroup.Name,
                    Measure = sm.Measure.Name,
                    Name = sm.Name,
                    PurchasePrice = sm.PurchasePrice,
                    Quantity = sm.Quantity,
                    SalePrice = sm.SalePrice
                })
                .ToList();

            int recsCount = await this.service
                .GetPredicatedCount(searchSortType, searchQuery);

            var pager = new Pager(recsCount, pages, pageSize)
            {
                Action = "SearchProducts",
                Controller = "Product",
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
        /// Action for adding a product in app (Asynchronous, GET)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> Add()
        {
            var formModel = new ProductFormModel
            {
                ItemGroups = await this.GetItemGroups(),
                Measures = await this.GetMeasures()
            };

            return View(formModel);
        }

        /// <summary>
        /// Action for adding a product in app (Asynchronous, POST)
        /// </summary>
        /// <param name="model">ProductFormModel - model to add</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> Add(ProductFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ItemGroups = await this.GetItemGroups();
                model.Measures = await this.GetMeasures();
                return View(model);
            }

            var serviceModel = new ProductServiceModel()
            {
                Name = model.Name,
                CashRegisterName = model.CashRegisterName,
                DateAdded = DateTime.Now,
                DateModified = DateTime.Now,
                Description = model.Description,
                CodeForScales = model.CodeForScales,
                PurchasePrice = decimal.Parse(model.PurchasePrice),
                SalePrice = decimal.Parse(model.SalePrice),
                Quantity = 0,
                ItemGroupId = model.ItemGroupId,
                MeasureId = model.MeasureId
            };

            await this.service.AddAsync(serviceModel);

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for editing a product by id in app (Asynchronous, GET)
        /// </summary>
        /// <param name="id">Id to use for update</param>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> Edit(string id)
        {
            try
            {
                if(!int.TryParse(id, out int parsed))
                {
                    logger.LogError("Bad request - Product/Edit - (GET)");
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var viewModel = new ProductFormModel()
                {
                    CashRegisterName = entity.CashRegisterName,
                    Name = entity.Name,
                    Description = entity.Description,
                    CodeForScales = entity.CodeForScales,
                    ItemGroupId = entity.ItemGroupId,
                    ItemGroups = await this.GetItemGroups(),
                    MeasureId = entity.MeasureId,
                    Measures = await this.GetMeasures(),
                    PurchasePrice = entity.PurchasePrice.ToString(),
                    SalePrice = entity.SalePrice.ToString(),
                };

                return View(viewModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Product/Edit - (GET)");
                return NotFound();
            }
        }

        /// <summary>
        /// Action for editing a product by id in app (Asynchronous, POST)
        /// </summary>
        /// <param name="id">Id to use for element</param>
        /// <param name="model">Form model to use</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> Edit(string id, ProductFormModel model)
        {
            if (model == null || 
                !int.TryParse(id, out int parsed))
            {
                logger.LogError("Bad request - Product/Edit - (POST)");
                return BadRequest();
            }

            try
            {
                var entity = await this.service.GetByIdAsync(parsed);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Product/Edit - (POST)");
                return NotFound();
            }

            var serviceModel = new ProductServiceModel()
            {
                Id = parsed,
                DateModified = DateTime.Now,
                Description = model.Description,
                ItemGroupId = model.ItemGroupId,
                MeasureId = model.MeasureId,
                Name = model.Name,
                CashRegisterName = model.CashRegisterName,
                PurchasePrice = decimal.Parse(model.PurchasePrice),
                SalePrice = decimal.Parse(model.SalePrice),
                CodeForScales = model.CodeForScales
            };

            await this.service.UpdateAsync(serviceModel);

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for deleting a product by id in app (Asynchronous, Get)
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
                    logger.LogError("Bad request - Product/Delete - (GET)");
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var viewModel = new ProductDeleteFormModel()
                {
                    Id = parsed,
                    CashRegisterName = entity.CashRegisterName,
                    Name = entity.Name,
                    Description = entity.Description,
                    CodeForScales = entity.CodeForScales,
                    ItemGroupId = entity.ItemGroupId,
                    ItemGroup = entity.ItemGroup.Name,
                    MeasureId = entity.MeasureId,
                    Measure = entity.Measure.Name,
                    PurchasePrice = entity.PurchasePrice,
                    SalePrice = entity.SalePrice,
                    Barcodes = entity.Barcodes.Select(b => b.Value)
                };

                return View("Delete", viewModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Product/Delete - (GET)");
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
                logger.LogError("Bad request - Product/Delete - (POST)");
                return BadRequest();
            }

            try
            {
                var model = await this.service.GetByIdAsync(parsed);

                var serviceModel = new ProductServiceModel()
                {
                    Id = parsed,
                    DateModified = DateTime.Now,
                    Description = model.Description,
                    ItemGroupId = model.ItemGroupId,
                    MeasureId = model.MeasureId,
                    Name = model.Name,
                    CashRegisterName = model.CashRegisterName,
                    PurchasePrice = model.PurchasePrice,
                    SalePrice = model.SalePrice,
                    CodeForScales = model.CodeForScales,
                    ArticleNumber = model.ArticleNumber,
                    NomenclatureNumber = model.NomenclatureNumber,
                    DateAdded = model.DateAdded,
                    ItemGroup = model.ItemGroup,
                    Measure = model.Measure,
                    Quantity = model.Quantity
                };

                await this.service.DeleteAsync(serviceModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Product/Delete - (POST)");
                return NotFound();
            }

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for checking product details (Asynchronous)
        /// </summary>
        /// <param name="id">Id to use</param>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> Details(string id)
        {
            try
            {
                if (!int.TryParse(id, out int parsed))
                {
                    logger.LogError("Bad request - Product/Details");
                    return BadRequest();
                }

                var entity = await this.service.GetByIdAsync(parsed);

                var viewModel = new ProductDetailsViewModel()
                {
                    CashRegisterName = entity.CashRegisterName,
                    Name = entity.Name,
                    Description = entity.Description,
                    CodeForScales = entity.CodeForScales,
                    ItemGroupName = entity.ItemGroup.Name,
                    Measure = entity.Measure.Name,
                    DateAdded = entity.DateAdded,
                    DateModified = entity.DateModified,
                    ArticleNumber = entity.ArticleNumber,
                    NomenclatureNumber = entity.NomenclatureNumber,
                    Quantity = entity.Quantity,
                    Barcodes = entity.Barcodes.Select(b => b.Value).ToList(),
                    PurchasePrice = entity.PurchasePrice,
                    SalePrice = entity.SalePrice,
                };

                return View(viewModel);
            }
            catch (EntityNotFoundException exc)
            {
                logger.LogError(exc, "Product/Details");
                return NotFound();
            }
        }

        /// <summary>
        /// Private method for accessing measures in app (used in actions)
        /// </summary>
        /// <returns>Task<IEnumerable<MeasureViewModel>></returns>
        private async Task<IEnumerable<MeasureViewModel>> GetMeasures()
        {
            var measuresServiceModels = await this.measureService
                .GetAllAsync();

            var measuresViewModels = measuresServiceModels
                .Select(msv => new MeasureViewModel
                {
                    Id = msv.Id,
                    Value = msv.Value
                });

            return measuresViewModels;
        }

        /// <summary>
        /// Private method for accessing item groups in app (used in actions)
        /// </summary>
        /// <returns>Task<IEnumerable<ItemGroupViewModel>></returns>
        private async Task<IEnumerable<ItemGroupViewModel>> GetItemGroups()
        {
            var itemGroupServiceModels = await this.itemGroupService
                 .GetAllAsync();

            var itemGroupViewModels = itemGroupServiceModels
                .Select(igsm => new ItemGroupViewModel
                {
                    Id = igsm.Id,
                    Name = igsm.Name
                });

            return itemGroupViewModels;
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
