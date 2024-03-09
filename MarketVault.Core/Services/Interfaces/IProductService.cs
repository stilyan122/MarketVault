namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

    /// <summary>
    /// Interface responsible for product service
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Asynchronous method to get all products 
        /// </summary>
        /// <returns>Task<IEnumerable<ProductServiceModel>></returns>
        Task<IEnumerable<ProductServiceModel>> GetAllAsync();

        /// <summary>
        /// Asynchronous method for adding a product
        /// </summary>
        /// <param name="product">Product service model</param>
        /// <returns>(void)</returns>
        Task AddAsync(ProductServiceModel product);

        /// <summary>
        /// Asynchronous method for updating a product
        /// </summary>
        /// <param name="product">Product service model</param>
        /// <returns>(void)</returns>
        Task UpdateAsync(ProductServiceModel product);

        /// <summary>
        /// Asynchronous for deleting a product
        /// </summary>
        /// <param name="product">Product service model</param>
        /// <returns>(void)</returns>
        Task DeleteAsync(ProductServiceModel product);
    }
}
