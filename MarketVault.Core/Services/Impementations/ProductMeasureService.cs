namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.Extensions.Logging;
    using System.Threading.Tasks;

    /// <summary>
    /// ProductMeasure service
    /// </summary>
    public class ProductMeasureService : IProductMeasureService
    {
        /// <summary>
        /// ProductMeasure repository
        /// </summary>
        private readonly IRepository<ProductMeasure> repository = null!;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<ProductMeasureService> logger = null!;

        /// <summary>
        /// Default constructor, injection of ProductMeasure repository and logger (DI)
        /// </summary>
        /// <param name="repository">ProductMeasure repository</param>
        /// <param name="logger">Logger</param>
        public ProductMeasureService(
            IRepository<ProductMeasure> repository,
            ILogger<ProductMeasureService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        /// <summary>
        /// Add product measure method (Asynchronous)
        /// </summary>
        /// <param name="productMeasure">ProductMeasure to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(ProductMeasureServiceModel productMeasure)
        {
            logger.LogInformation("Add async method in product measure service invoked.");

            var entity = new ProductMeasure()
            {
                MeasureId = productMeasure.MeasureId,
                ProductId = productMeasure.ProductId
            };

            await this.repository.AddAsync(entity);
        }
    }
}
