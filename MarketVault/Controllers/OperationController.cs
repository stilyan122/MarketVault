﻿namespace MarketVault.Controllers
{
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.Address;
    using MarketVault.Models.CounterParty;
    using MarketVault.Models.DocumentType;
    using MarketVault.Models.Operation;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

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
        /// Document type service
        /// </summary>
        private readonly IDocumentTypeService documentTypeService;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly Logger<OperationController> logger;

        /// <summary>
        /// Constructor injecting logger and services
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="service">IOperationService</param>
        /// <param name="counterPartyService">ICounterPartyService</param>
        /// <param name="documentTypeService">IDocumentTypeService</param>
        public OperationController(
            Logger<OperationController> logger,
            IOperationService service,
            ICounterPartyService counterPartyService,
            IDocumentTypeService documentTypeService)
        {
            this.counterPartyService = counterPartyService;
            this.logger = logger;
            this.service = service;
            this.documentTypeService = documentTypeService;
        }

        [Authorize(Roles = "Admin,Worker")]
        public IActionResult Index()
        {
            return View("New");
        }

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

            return View("SuccessfullyAdded");
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
