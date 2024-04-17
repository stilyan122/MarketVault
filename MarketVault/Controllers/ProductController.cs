namespace MarketVault.Controllers
{
    using MarketVault.Core;
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Extensions;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using MarketVault.Models.ItemGroup;
    using MarketVault.Models.Measure;
    using MarketVault.Models.Product;
    using MarketVault.Models.Search;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.VisualBasic;
    using System;
    using System.Web;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.BarcodeConstants;
    using static MarketVault.Infrastructure
      .Constants.DataConstants.RoleConstants;

    /// <summary>
    /// Product Controller (Authorized)
    /// </summary>
    public class ProductController : BaseController
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
        /// <param name="pages">Pager pages</param>
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
                    SalePrice = sm.SalePrice,
                    Information = sm.DateAdded.ToString().Substring(0, 4) +
                    sm.Name.Substring(0, 5) + sm.Measure.Name +
                    sm.SalePrice.ToString().Substring(0, 1)
                    + sm.CashRegisterName.Substring(0, 3)
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
        /// <param name="searchSortType">Search sort type</param>
        /// <param name="searchViewName">View name for searching</param>
        /// <param name="searchQuery">Search query</param>
        /// <param name="pages">Pager pages</param>
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
                    SalePrice = sm.SalePrice,
                    Information = sm.DateAdded.ToString().Substring(0, 4) +
                    sm.Name.Substring(0, 5) + sm.Measure.Name +
                    sm.SalePrice.ToString().Substring(0, 1)
                    + sm.CashRegisterName.Substring(0, 3)
                })
                .ToList();

            int recsCount = await this.service
                .GetPredicatedCountAsync(searchSortType, searchQuery);

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
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Add()
        {
            var formModel = new ProductFormModel
            {
                ItemGroups = await this.GetItemGroups(),
                Measures = await this.GetMeasures(),
                BarcodeMaxLength = ValueMaxLength,
                BarcodeMinLength = ValueMinLength
            };

            return View(formModel);
        }

        /// <summary>
        /// Action for adding a product in app (Asynchronous, POST)
        /// </summary>
        /// <param name="model">ProductFormModel - model to add</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Add([FromForm]ProductFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.ItemGroups = await this.GetItemGroups();
                model.Measures = await this.GetMeasures();
                model.BarcodeMaxLength = ValueMaxLength;
                model.BarcodeMinLength = ValueMinLength;
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
                PurchasePrice = model.PurchasePrice,
                SalePrice = model.SalePrice,
                Quantity = 0,
                ItemGroupId = model.ItemGroupId ?? 0,
                MeasureId = model.MeasureId ?? 0,
            };

            foreach (string barcode in model.Barcodes)
            {
                serviceModel.Barcodes.Add(new Barcode()
                {
                    Value = barcode
                });
            }

            await this.service.AddAsync(serviceModel);

            return RedirectToAction("All");
        }
        
        /// <summary>
        /// Action for editing a product by id in app (Asynchronous, GET)
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
                    PurchasePrice = entity.PurchasePrice,
                    SalePrice = entity.SalePrice,
                    Information = entity.DateAdded.ToString().Substring(0, 4) +
                    entity.Name.Substring(0, 5) + entity.Measure.Name +
                    entity.SalePrice.ToString().Substring(0, 1)
                    + entity.CashRegisterName.Substring(0, 3)
                };

                if (viewModel.GetDetails() != details)
                {
                    logger.LogError("Bad request - Product/Edit - (GET)");
                    return BadRequest();
                }

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
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Edit(string id, ProductFormModel model)
        {
            if (model == null || 
                !int.TryParse(id, out int parsed))
            {
                logger.LogError("Bad request - Product/Edit - (POST)");
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                model.ItemGroups = await this.GetItemGroups();
                model.Measures = await this.GetMeasures();
                return View(model);
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
                ItemGroupId = model.ItemGroupId ?? 0,
                MeasureId = model.MeasureId ?? 0,
                Name = model.Name,
                CashRegisterName = model.CashRegisterName,
                PurchasePrice = model.PurchasePrice,
                SalePrice = model.SalePrice,
                CodeForScales = model.CodeForScales
            };

            await this.service.UpdateAsync(serviceModel);

            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for deleting a product by id in app (Asynchronous, Get)
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
                    Barcodes = entity.Barcodes.Select(b => b.Value),
                    Information = entity.DateAdded.ToString().Substring(0, 4) +
                    entity.Name.Substring(0, 5) + entity.Measure.Name +
                    entity.SalePrice.ToString().Substring(0, 1)
                    + entity.CashRegisterName.Substring(0, 3)
                };

                if (viewModel.GetDetails() != details)
                {
                    logger.LogError("Bad request - Product/Delete - (GET)");
                    return BadRequest();
                }

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
        /// <param name="model">ProductDeleteFormModel</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> Delete(string id, 
            ProductDeleteFormModel model)
        {
            if (model == null || !int.TryParse(id, out int parsed))
            {
                logger.LogError("Bad request - Product/Delete - (POST)");
                return BadRequest();
            }

            try
            {
                var oldServiceModel = await this.service.GetByIdAsync(parsed);

                var serviceModel = new ProductServiceModel()
                {
                    Id = parsed,
                    DateModified = DateTime.Now,
                    Description = oldServiceModel.Description,
                    ItemGroupId = oldServiceModel.ItemGroupId,
                    MeasureId = oldServiceModel.MeasureId,
                    Name = oldServiceModel.Name,
                    CashRegisterName = oldServiceModel.CashRegisterName,
                    PurchasePrice = oldServiceModel.PurchasePrice,
                    SalePrice = oldServiceModel.SalePrice,
                    CodeForScales = oldServiceModel.CodeForScales,
                    ArticleNumber = oldServiceModel.ArticleNumber,
                    NomenclatureNumber = oldServiceModel.NomenclatureNumber,
                    DateAdded = oldServiceModel.DateAdded,
                    ItemGroup = oldServiceModel.ItemGroup,
                    Measure = oldServiceModel.Measure,
                    Quantity = oldServiceModel.Quantity
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
        /// <param name="details">Details</param>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> Details(string id, string details)
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
                    Information = entity.DateAdded.ToString().Substring(0, 4) +
                    entity.Name.Substring(0, 5) + entity.Measure.Name +
                    entity.SalePrice.ToString().Substring(0, 1)
                    + entity.CashRegisterName.Substring(0, 3)
                };

                if (HttpUtility.UrlEncode(viewModel.Information) != details)
                {
                    logger.LogError("Bad request - Product/Details");
                    return BadRequest();
                }

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
