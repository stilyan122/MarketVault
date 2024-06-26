﻿namespace MarketVault.Controllers
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
    using static MarketVault.Infrastructure
       .Constants.DataConstants.RoleConstants;

    /// <summary>
    /// Item Group Controller (Authorized)
    /// </summary>
    public class OperationController : BaseController
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
        /// <param name="productService">IProductService</param>
        public OperationController(
            ILogger<OperationController> logger,
            IOperationService service,
            ICounterPartyService counterPartyService,
            IDocumentTypeService documentTypeService,
            IProductService productService)
        {
            this.counterPartyService = counterPartyService;
            this.logger = logger;
            this.service = service;
            this.documentTypeService = documentTypeService;
            this.productService = productService;
        }

        /// <summary>
        /// Default index method
        /// </summary>
        /// <returns>IActionResult</returns>
        [Authorize(Roles = WorkerAndAdminRoles)]
        public IActionResult Index()
        {
            logger.LogInformation("Operation/Index action invoked.");
            return View("New");
        }

        /// <summary>
        /// Method for adding a new operation (Asynchronous, GET)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        [HttpGet]
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> New()
        {
            logger.LogInformation("Operation/New action ivnoked.");
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
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> 
            AddNewOperation(OperationFormModel model)
        {
            logger.LogInformation("Operation/AddNewOperation action ivnoked (GET).");
            if (!ModelState.IsValid)
            {
                model = new OperationFormModel()
                {
                    CounterParties = await this.GetCounterParties(),
                    DocumentTypes = await this.GetDocumentTypes(),
                    ProductsJson = model.ProductsJson,
                    Products = model.Products
                };

                for (int i = 0; i < model.ProductsJson.Count; i++)
                {
                    var product = model.Products[i];
                    var json = model.ProductsJson[i];

                    var productModel = JsonConvert
                            .DeserializeObject<ProductOperationModel>(json) ??
                            new ProductOperationModel();

                    productModel.PurchasePrice = product.PurchasePrice;
                    productModel.SalePrice = product.SalePrice;
                    productModel.Quantity = product.Quantity;
                    model.Products[i] = productModel;
                }

                this.TempData["OperationTempDataModel"] = JsonConvert
                .SerializeObject(model);

                return View("New", model);
            }

            var serviceModel = new OperationServiceModel()
            {
                DateMade = DateTime.Now,
                DocumentTypeId = model.DocumentTypeId ?? 0,
                CounterPartyId = model.CounterPartyId ?? 0,
                UserId = User.Id()
            };

            for (int i = 0; i < model.ProductsJson.Count; i++)
            {
                var product = model.Products[i];
                var json = model.ProductsJson[i];

                var productModel = JsonConvert
                        .DeserializeObject<ProductOperationModel>(json) ??
                        new ProductOperationModel();

                var dbProduct = await this.productService.GetByIdAsync(productModel.Id ?? 1);

                if (model.DocumentTypeId == 1 || model.DocumentTypeId == 2)
                {
                    dbProduct.Quantity += product.Quantity ?? 0;
                }
                else
                {
                    dbProduct.Quantity -= product.Quantity ?? 0;
                }

                dbProduct.SalePrice = product.SalePrice;
                dbProduct.PurchasePrice = product.PurchasePrice;

                await this.productService.UpdateAsync(dbProduct);
            }

            serviceModel.TotalPurchasePriceWithoutVAT =
                model.Products.Sum(p => p.PurchasePrice * p.Quantity ?? 1);
            serviceModel.TotalPurchasePriceWithVAT =
                model.Products.Sum(p => p.PurchasePrice * (p.Quantity ?? 1) + 0.20M * p.PurchasePrice 
                * p.Quantity ?? 1);

            serviceModel.TotalSalePriceWithoutVAT =
                model.Products.Sum(p => p.SalePrice * p.Quantity ?? 1);
            serviceModel.TotalSalePriceWithVAT =
                model.Products.Sum(p => p.SalePrice * p.Quantity ?? 1 + 0.20M * p.SalePrice
                 * p.Quantity ?? 1);

            var products = new List<ProductOperationModel>();

            model.ProductsJson.ForEach(json =>
            {
                products.Add(JsonConvert
                        .DeserializeObject<ProductOperationModel>(json) ?? new ProductOperationModel());
            });

            var productOperationServiceModel = new ProductOperationServiceModel()
            {
                DocumentTypeId = model.DocumentTypeId,
                CounterPartyId = model.CounterPartyId,
                Products = products.Select(p => new ProductForOperationServiceModel(){
                    Id = p.Id ?? 1,
                    PurchasePrice = p.PurchasePrice,
                    Quantity = p.Quantity ?? 1,
                    SalePrice = p.SalePrice
                })
                .ToList(),
                ProductsJson = model.ProductsJson
            };

            await this.service.AddAsync(serviceModel, productOperationServiceModel);

            return View("SuccessfullyAdded");
        }

        /// <summary>
        /// Method for adding a product to operation (GET)
        /// </summary>
        /// <returns></returns>
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> AddProductToOperation(OperationFormModel 
            operationFormModel)
        {
            logger.LogInformation("Operation/AddProductToOperation action ivnoked.");
            var tempDataModel = new OperationTempDataModel()
            {
                DocumentTypeId = operationFormModel.DocumentTypeId ?? 0,
                CounterPartyId = operationFormModel.CounterPartyId ?? 0,
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
        [Authorize(Roles = WorkerAndAdminRoles)]
        public async Task<IActionResult> 
            AddProductToOperationPost(ProductOperationModel
            model)
        {
            logger.LogInformation("Operation/AddNewOperation action ivnoked (POST).");

            var products = await this.GetProducts();
            var product = products.FirstOrDefault(p => p.Id == model.Id);

            if (!ModelState.IsValid || product == null)
            {
                model.Products = await this.GetProducts();

                return View("AddProductToOperation", model);
            }

            var operationTempDataModel = JsonConvert
                .DeserializeObject<OperationTempDataModel>(
                TempData.Peek("OperationTempDataModel")?.ToString() ?? "");

            if (operationTempDataModel?.DocumentTypeId == 3 ||
                operationTempDataModel?.DocumentTypeId == 4)
            {
                if (model.Quantity > products.First(p => p.Id == model.Id).Quantity)
                {
                    return View("AddProductToOperation", model);
                }
            }

            model.CashRegisterName = product.CashRegisterName;
            model.Name = product.Name;
            model.PurchasePrice = product.PurchasePrice;
            model.SalePrice = product.SalePrice;

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
        /// Method for accessing user operations
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult>
            GetYourOperations()
        {
            logger.LogInformation("Operation/GetYourOperations action ivnoked.");

            if (String.IsNullOrEmpty(User.Id()))
            {
                return BadRequest();
            }

            var serviceModels = await this.service.GetUserOperationsAsync(User.Id());

            var viewModels = serviceModels.Select(sm => new OperationViewModel()
            {
                Id = sm.Id,
                DateMade = sm.DateMade,
                DocumentType = sm.DocumentType.Name,
                CounterParty = sm.CounterParty.Name,
                ProductsCount = sm.ProductsCount,
                TotalPurchasePriceWithoutVAT = sm.TotalPurchasePriceWithoutVAT,
                TotalPurchasePriceWithVAT = sm.TotalPurchasePriceWithVAT,
                TotalSalePriceWithoutVAT = sm.TotalSalePriceWithoutVAT,
                TotalSalePriceWithVAT = sm.TotalSalePriceWithVAT,
                UserId = User.Id()
            })
                .OrderByDescending(sm => sm.DateMade);

            return View(viewModels);
        }

        /// <summary>
        /// Private method for accessing counter parties in app (used in actions)
        /// </summary>
        /// <returns>Task<IEnumerable<CounterPartyViewModel>></returns>
        private async Task<IEnumerable<CounterPartyViewModel>> GetCounterParties()
        {
            logger.LogInformation("Operation/GetCounterParties action ivnoked.");
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
            logger.LogInformation("Operation/GetDocumentTypes action ivnoked.");
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
            logger.LogInformation("Operation/GetProducts action ivnoked.");
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
