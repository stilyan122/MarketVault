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
        /// Logger
        /// </summary>
        private readonly ILogger<OperationService> logger = null!;

        /// <summary>
        /// Default constructor, injection of Operation repository and logger (DI)
        /// </summary>
        /// <param name="repository">Operation repository</param>
        /// <param name="logger">Logger</param>
        public OperationService(
            IRepository<Operation> repository,
            ILogger<OperationService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        /// <summary>
        /// Asynchronous method for adding an Operation entity
        /// </summary>
        /// <param name="operation">OperationServiceModel service model</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(OperationServiceModel operation)
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
                TotalSalePriceWithVAT = operation.TotalSalePriceWithVAT
            };

            await this.repository.AddAsync(entity);
        }
    }
}
