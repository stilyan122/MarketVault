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
        /// Get matching products paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns></returns>
        public Task<IEnumerable<ProductServiceModel>> GetAllByPredicatePagedAsync(
            string sortType, string value,
            int pageSize, int pageNumber);

        /// <summary>
        /// Get all products that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<ProductServiceModel></returns>
        public IQueryable<ProductServiceModel> GetAllByPredicateAsync
            (string sortType, string value);

        /// <summary>
        /// Method to get count of sorted paginated products
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <returns>Task<int></returns>
        public Task<int> GetPredicatedCountAsync(string sortType, string value);

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
