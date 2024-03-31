namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// Product operation service
    /// </summary>
    public class ProductOperationService : IProductOperationService
    {
        /// <summary>
        /// ProductMeasure repository
        /// </summary>
        private readonly IRepository<ProductOperation> repository = null!;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<ProductOperationService> logger = null!;

        /// <summary>
        /// Default constructor, injection of ProductOperation repository and logger (DI)
        /// </summary>
        /// <param name="repository">ProductOperation repository</param>
        /// <param name="logger">Logger</param>
        public ProductOperationService(
            IRepository<ProductOperation> repository,
            ILogger<ProductOperationService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        /// <summary>
        /// Add product operation method (Asynchronous)
        /// </summary>
        /// <param name="productOperation">ProductOperation to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(ProductOperationServiceModel productOperation)
        {
            logger.LogInformation("Add async method in product operation service invoked.");

            var entity = new ProductOperation()
            {
                OperationId = productOperation.OperationId,
                ProductId = productOperation.ProductId
            };

            await this.repository.AddAsync(entity);
        }
    }
}
