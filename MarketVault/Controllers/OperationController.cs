namespace MarketVault.Controllers
{
    using MarketVault.Core.Extensions;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.CounterParty;
    using MarketVault.Models.DocumentType;
    using MarketVault.Models.Operation;
    using MarketVault.Models.Product;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;

    /// <summary>
    /// Item Group Controller (Authorized)
    /// </summary>
    [Authorize]
    public class OperationController : Controller
    {
        /// <summary>
        /// IOperation service
        /// </summary>
        private readonly IOperationService service;

        /// <summary>
        /// Counter party service
        /// </summary>
        private readonly ICounterPartyService counterPartyService;

        /// <summary>
        /// Product service
        /// </summary>
        private readonly IProductService productService;

        /// <summary>
        /// Product operation service
        /// </summary>
        private readonly IProductOperationService productOperationService;

        /// <summary>
        /// Document type service
        /// </summary>
        private readonly IDocumentTypeService documentTypeService;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<OperationController> logger;

        /// <summary>
        /// Constructor injecting logger and services
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="service">IOperationService</param>
        /// <param name="counterPartyService">ICounterPartyService</param>
        /// <param name="documentTypeService">IDocumentTypeService</param>
        /// <param name="productOperationService">IProductOperationService</param>
        /// <param name="productService">IProductService</param>
        public OperationController(
            ILogger<OperationController> logger,
            IOperationService service,
            ICounterPartyService counterPartyService,
            IDocumentTypeService documentTypeService,
            IProductOperationService productOperationService,
            IProductService productService)
        {
            this.counterPartyService = counterPartyService;
            this.logger = logger;
            this.service = service;
            this.documentTypeService = documentTypeService;
            this.productOperationService = productOperationService;
            this.productService = productService;
        }

        /// <summary>
        /// Default index method
        /// </summary>
        /// <returns>IActionResult</returns>
        [Authorize(Roles = "Admin,Worker")]
        public IActionResult Index()
        {
            return View("New");
        }

        /// <summary>
        /// Method for adding a new operation (Asynchronous, GET)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> New()
        {
            var model = new OperationFormModel()
            {
                CounterParties = await this.GetCounterParties(),
                DocumentTypes = await this.GetDocumentTypes()
            };

            return View(model);
        }

        /// <summary>
        /// Method for adding a new operation (Asynchronous, POST)
        /// </summary>
        /// <param name="model">OperationFormModel</param>
        /// <returns>Task<IActionResult></returns>
        [HttpPost]
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> 
            AddNewOperation(OperationFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model = new OperationFormModel()
                {
                    CounterParties = await this.GetCounterParties(),
                    DocumentTypes = await this.GetDocumentTypes()
                };

                return View("New", model);
            }

            var serviceModel = new OperationServiceModel()
            {
                DateMade = DateTime.Now,
                DocumentTypeId = model.DocumentTypeId,
                CounterPartyId = model.CounterPartyId,
                TotalPurchasePriceWithoutVAT = model.Products.Sum(p => p.PurchasePrice),
                TotalPurchasePriceWithVAT = model.Products.Sum(p => p.PurchasePrice +
                0.20M * p.PurchasePrice),
                TotalSalePriceWithoutVAT = model.Products.Sum(p => p.SalePrice),
                TotalSalePriceWithVAT = model.Products.Sum(p => p.SalePrice +
                0.20M * p.SalePrice),
                UserId = User.Id()
            };

            //await this.service.AddAsync(serviceModel);

            //foreach (ProductOperationModel pom in model.Products)
            //{
            //    var productOperation = new ProductOperationServiceModel()
            //    {
            //        OperationId = model.Id,
            //        ProductId = pom.Id
            //    };

            //    await this.productOperationService.AddAsync(productOperation);
            //}

            return View("SuccessfullyAdded");
        }

        /// <summary>
        /// Method for adding a product to operation (GET)
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> AddProductToOperation(OperationFormModel 
            operationFormModel)
        {
            var tempDataModel = new OperationTempDataModel()
            {
                DocumentTypeId = operationFormModel.DocumentTypeId,
                CounterPartyId = operationFormModel.CounterPartyId,
                Products = new List<ProductOperationModel>()
            };

            foreach (string json in operationFormModel.ProductsJson)
            {
                tempDataModel.Products.Add(JsonConvert
                    .DeserializeObject<ProductOperationModel>(json) ?? 
                    new ProductOperationModel());
            }

            this.TempData["OperationTempDataModel"] = JsonConvert
                .SerializeObject(tempDataModel);

            var model = new ProductOperationModel()
            {
                Products = await this.GetProducts(),
            };

            return View(model);
        }
        /// <summary>
        /// Method for adding a product to operation (POST)
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Admin,Worker")]
        public async Task<IActionResult> 
            AddProductToOperationPost(ProductOperationModel
            model)
        {
            if (!ModelState.IsValid)
            {
                model.Products = await this.GetProducts();
                return View(model);
            }

            var operationTempDataModel = JsonConvert
                .DeserializeObject
                <OperationTempDataModel>(
                TempData.Peek("OperationTempDataModel")?.ToString() ?? "");

            operationTempDataModel?.Products.Add(model);

            var operationFormModel = new OperationFormModel()
            {
                CounterPartyId = operationTempDataModel?.CounterPartyId ?? 0,
                CounterParties = await this.GetCounterParties(),
                DocumentTypeId = operationTempDataModel?.DocumentTypeId ?? 0,
                DocumentTypes = await this.GetDocumentTypes(),
                Products = operationTempDataModel?.Products?.ToList() ??
                new List<ProductOperationModel>()
            };

            return View("New", operationFormModel);
        }

        /// <summary>
        /// Private method for accessing counter parties in app (used in actions)
        /// </summary>
        /// <returns>Task<IEnumerable<CounterPartyViewModel>></returns>
        private async Task<IEnumerable<CounterPartyViewModel>> GetCounterParties()
        {
            var counterPartyServiceModels = await this.counterPartyService
                 .GetAllAsync();

            var counterPartyViewModels = counterPartyServiceModels
                .Select(cpsm => new CounterPartyViewModel
                {
                    Id = cpsm.Id,
                    Name = cpsm.Name
                });

            return counterPartyViewModels;
        }

        /// <summary>
        /// Private method for accessing document types in app (used in actions)
        /// </summary>
        /// <returns>Task<IEnumerable<DocumentTypeViewModel>></returns>
        private async Task<IEnumerable<DocumentTypeViewModel>> GetDocumentTypes()
        {
            var documentTypeServiceModels = await this.documentTypeService
                 .GetAllAsync();

            var documentTypeViewModels = documentTypeServiceModels
                .Select(dtsm => new DocumentTypeViewModel
                {
                    Id = dtsm.Id,
                    Name = dtsm.Name
                });

            return documentTypeViewModels;
        }

        /// <summary>
        /// Private method for accessing products in app (used in actions)
        /// </summary>
        /// <returns>Task<IEnumerable<ProductDetailsViewModel>></returns>
        private async Task<IEnumerable<ProductDetailsViewModel>> GetProducts()
        {
            var productServiceModels = await this.productService
                 .GetAllAsync();

            var productViewModels = productServiceModels
                .Select(psm => new ProductDetailsViewModel
                {
                    Id = psm.Id,
                    DateAdded = psm.DateAdded,
                    DateModified = psm.DateModified,
                    Description = psm.Description,
                    Barcodes = psm.Barcodes.Select(b => b.Value),
                    ArticleNumber = psm.ArticleNumber,
                    Name = psm.Name,
                    NomenclatureNumber = psm.NomenclatureNumber, 
                    CashRegisterName = psm.CashRegisterName,
                    CodeForScales = psm.CodeForScales,
                    ItemGroupName = psm.ItemGroup.Name,
                    Measure = psm.Measure.Name,
                    PurchasePrice = psm.PurchasePrice,
                    Quantity = psm.Quantity,
                    SalePrice = psm.SalePrice
                });

            return productViewModels;
        }
    }
}
