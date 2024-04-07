namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.Extensions.Logging;
    using System.Threading.Tasks;

    /// <summary>
    /// Operation Service
    /// </summary>
    public class OperationService : IOperationService
    {
        /// <summary>
        /// Measure repository
        /// </summary>
        private readonly IRepository<Operation> repository = null!;

        /// <summary>
        /// Product operation service
        /// </summary>
        private readonly IProductOperationService productOperationService = null!;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<OperationService> logger = null!;

        /// <summary>
        /// Default constructor, injection of Operation repository, logger and services (DI)
        /// </summary>
        /// <param name="repository">Operation repository</param>
        /// <param name="logger">Logger</param>
        /// <param name="productOperationService">IProductOperationService</param>
        public OperationService(
            IRepository<Operation> repository,
            ILogger<OperationService> logger,
            IProductOperationService productOperationService)
        {
            this.repository = repository;
            this.logger = logger;
            this.productOperationService = productOperationService;
        }

        /// <summary>
        /// Asynchronous method for adding an Operation entity
        /// </summary>
        /// <param name="operation">OperationServiceModel service model</param>
        /// <param name="model">ProductOperation service model</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(OperationServiceModel operation, 
            ProductOperationServiceModel model)
        {
            logger.LogInformation("Add async method in operation service invoked.");

            var entity = new Operation()
            {
                DocumentTypeId = operation.DocumentTypeId,
                CounterPartyId = operation.CounterPartyId,
                DateMade = operation.DateMade,
                TotalPurchasePriceWithoutVAT = operation.TotalPurchasePriceWithoutVAT,
                TotalPurchasePriceWithVAT = operation.TotalPurchasePriceWithVAT,
                TotalSalePriceWithoutVAT = operation.TotalSalePriceWithoutVAT,
                TotalSalePriceWithVAT = operation.TotalSalePriceWithVAT,
                UserId = operation.UserId
            };

            await this.repository.AddAsync(entity);

            foreach (ProductForOperationServiceModel pom in model.Products)
            {
                var productOperation = new ProductOperationServiceModel()
                {
                    OperationId = entity.Id,
                    ProductId = pom.Id
                };

                await this.productOperationService.AddAsync(productOperation);
            }
        }
    }
}
