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
        public OperationController(
            Logger<OperationController> logger,
            IOperationService service,
            ICounterPartyService counterPartyService,
            IDocumentTypeService documentTypeService,
            IProductOperationService productOperationService)
        {
            this.counterPartyService = counterPartyService;
            this.logger = logger;
            this.service = service;
            this.documentTypeService = documentTypeService;
            this.productOperationService = productOperationService;
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
        [HttpGet]
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

            await this.service.AddAsync(serviceModel);

            foreach (ProductOperationModel pom in model.Products)
            {
                var productOperation = new ProductOperationServiceModel()
                {
                    OperationId = model.Id,
                    ProductId = pom.Id
                };

                await this.productOperationService.AddAsync(productOperation);
            }

            return View("SuccessfullyAdded");
        }

        /// <summary>
        /// Method for adding a product to operation (GET)
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = "Admin,Worker")]
        public IActionResult AddProductToOperation(OperationFormModel 
            operationFormModel)
        {
            if (!ModelState.IsValid)
            {
                return View(operationFormModel);
            }

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
    }
}
