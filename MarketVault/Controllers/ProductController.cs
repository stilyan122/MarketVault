namespace MarketVault.Controllers
{
    using MarketVault.Core;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.ItemGroup;
    using MarketVault.Models.Measure;
    using MarketVault.Models.Product;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

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

            var pager = new Pager(recsCount, pages, pageSize);

            int recsSkip = (pages - 1) * pageSize;

            var data = viewModels
                .Skip(recsSkip)
                .Take(pager.PageSize)
                .ToList();

            this.ViewBag.Pager = pager;

            return View(data);
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
    }
}
