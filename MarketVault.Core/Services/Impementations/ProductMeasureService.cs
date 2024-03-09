namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
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
        /// Default constructor, injection of ProductMeasure repository (DI)
        /// </summary>
        /// <param name="repository">ProductMeasure repository</param>
        public ProductMeasureService(IRepository<ProductMeasure> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Add product measure method (Asynchronous)
        /// </summary>
        /// <param name="productMeasure">ProductMeasure to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(ProductMeasureServiceModel productMeasure)
        {
            var entity = new ProductMeasure()
            {
                MeasureId = productMeasure.MeasureId,
                ProductId = productMeasure.ProductId
            };

            await this.repository.AddAsync(entity);
        }
    }
}
