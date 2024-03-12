namespace MarketVault.Controllers
{
    using MarketVault.Core;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
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
        /// ProductMeasure Service
        /// </summary>
        private readonly IProductMeasureService productMeasureService = null!;

        /// <summary>
        /// Default constructor, injecting services (DI)
        /// </summary>
        /// <param name="service">IProductService</param>
        /// <param name="itemGroupService">IItemGroupService</param>
        /// <param name="measureService">IMeasureService</param>
        /// <param name="productMeasureService">IProductMeasureService</param>
        public ProductController(IProductService service,
            IItemGroupService itemGroupService,
            IMeasureService measureService,
            IProductMeasureService productMeasureService)
        {
            this.service = service;
            this.itemGroupService = itemGroupService;
            this.measureService = measureService;
            this.productMeasureService = productMeasureService;
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
                string sortType,
                string value,
                string viewName, 
                int pages = 1)
        {
            if (value == null || 
                String.IsNullOrEmpty(value) || 
                String.IsNullOrWhiteSpace(value))
            {
                return RedirectToAction("All");
            }

            var predicate = GetCorrectPredicate(sortType, value);

            var serviceModels = await this.service
                .GetAllByPredicateAsync(predicate);

            var viewModels = serviceModels
                .Select(sm => new ProductViewModel()
                {
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
                Action = "SearchProducts",
                Controller = "Product"
            };

            var searcher = new SearchModel()
            {
                ViewName = viewName,
                SortType = sortType,
                Value = value,
                IsInSearch = true
            };

            int recsSkip = (pages - 1) * pageSize;

            var data = viewModels
                .Skip(recsSkip)
                .Take(pager.PageSize)
                .ToList();

            this.ViewBag.Pager = pager;
            this.ViewBag.Searcher = searcher; 

            if (viewName == null ||
                String.IsNullOrEmpty(viewName) ||
                String.IsNullOrWhiteSpace(viewName))
            {
                viewName = "Index";
            }

            return View(viewName, data);
        }

        /// <summary>
        /// Action for adding a product in app (Asynchronous, GET)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
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
                PurchasePrice = model.PurchasePrice,
                SalePrice = model.SalePrice,
                Quantity = 0,
                ItemGroupId = model.ItemGroupId,
                MeasureId = model.MeasureId
            };

            var productMeasureServiceModel = new ProductMeasureServiceModel()
            {
                MeasureId = model.MeasureId
            };

            await this.productMeasureService.AddAsync(productMeasureServiceModel);
            await this.service.AddAsync(serviceModel);

            return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var entity = await this.service.GetByIdAsync(id);

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
                };

                return View(viewModel);
            }
            catch (ArgumentNullException)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ProductFormModel model)
        {
            var serviceModel = new ProductServiceModel()
            {
                Id = id,
                DateModified = DateTime.Now,
                Description = model.Description,
                ItemGroupId = model.ItemGroupId,
                MeasureId = model.MeasureId,
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
        /// Private method for getting correct predicate for sorting products
        /// </summary>
        /// <param name="sortType">Sort Type to use</param>
        /// <param name="value">Value of the sorter</param>
        /// <returns>Predicate<Product></returns>
        private static Predicate<Product> GetCorrectPredicate(string sortType, 
            string value)
        {
            return sortType switch
            {
                "Name" => x => x.Name == value,
                "Cash Register Name" => x => x.CashRegisterName == value,
                "Article Number" => x => x.ArticleNumber == int.Parse(
                                        value),
                "Nomenclature Number" => x => x.NomenclatureNumber == int.Parse(
                                        value),
                "Sale Price" => x => x.SalePrice == decimal.Parse(
                                        value),
                "Purchase Price" => x => x.PurchasePrice == decimal.Parse(
                                        value),
                "Item Group Name" => x => x.ItemGroup.Name == value,
                "Measure" => x => x.ProductsMeasures
                                    .First()
                                    .Measure
                                    .Name == value,
                _ => x => x.Id == 0,
            };
        }
    }
}
