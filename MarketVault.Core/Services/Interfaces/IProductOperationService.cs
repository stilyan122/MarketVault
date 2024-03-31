namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

    /// <summary>
    /// Interface responsible for product operation service
    /// </summary>
    public interface IProductOperationService
    {
        /// <summary>
        /// Asynchronous method for adding a productOperation entity
        /// </summary>
        /// <param name="productOperation">ProductOperation service model</param>
        /// <returns>(void)</returns>
        Task AddAsync(ProductOperationServiceModel productOperation);
    }
}
