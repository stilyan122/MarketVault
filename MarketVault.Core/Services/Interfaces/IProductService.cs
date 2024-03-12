namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;
    using MarketVault.Infrastructure.Data.Models;

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
        /// Asynchronous method to get all products with condition
        /// </summary>
        /// <returns>Task<IEnumerable<ProductServiceModel>></returns>
        Task<IEnumerable<ProductServiceModel>> GetAllByPredicateAsync
            (Predicate<Product> condition);

        /// <summary>
        /// Asynchronous method to get a product by a given id
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<ProductServiceModel></returns>
        Task<ProductServiceModel> GetByIdAsync (int id);

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
