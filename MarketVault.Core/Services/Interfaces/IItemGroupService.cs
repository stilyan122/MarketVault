namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

    /// <summary>
    /// Interface responsible for item group service
    /// </summary>
    public interface IItemGroupService
    {
        /// <summary>
        /// Asynchronous method to get all item groups 
        /// </summary>
        /// <returns>Task<IEnumerable<ItemGroupServiceModel>></returns>
        Task<IEnumerable<ItemGroupServiceModel>> GetAllAsync();

        /// <summary>
        /// Get all item groups that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<ItemGroupServiceModel></returns>
        public IQueryable<ItemGroupServiceModel> GetAllByPredicateAsync
            (string sortType, string value);

        /// <summary>
        /// Get matching item groups paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns></returns>
        public Task<IEnumerable<ItemGroupServiceModel>> GetAllByPredicatePagedAsync(
            string sortType, string value,
            int pageSize, int pageNumber);

        /// <summary>
        /// Method to get count of sorted paginated item groups
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <returns>Task<int></returns>
        public Task<int> GetPredicatedCountAsync(string sortType, string value);

        /// <summary>
        /// Add item group method (Asynchronous)
        /// </summary>
        /// <param name="itemGroup">Item group to add</param>
        /// <returns>(void)</returns>
        public Task AddAsync(ItemGroupServiceModel itemGroup);

        /// <summary>
        /// Delete item group method (Asynchronous)
        /// </summary>
        /// <param name="itemGroup">Product to delete</param>
        /// <returns>(void)</returns>
        public Task DeleteAsync(ItemGroupServiceModel itemGroup);

        /// <summary>
        /// Get a item group by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<ItemGroupServiceModel></returns>
        public Task<ItemGroupServiceModel> GetByIdAsync(int id);

        /// <summary>
        /// Update item group method (Asynchronous)
        /// </summary>
        /// <param name="product">Item group to update</param>
        /// <returns>(void)</returns>
        public Task UpdateAsync(ItemGroupServiceModel itemGroup);
    }
}
