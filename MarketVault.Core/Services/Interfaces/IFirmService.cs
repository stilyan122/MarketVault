namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

    /// <summary>
    /// Interface responsible for firm service
    /// </summary>
    public interface IFirmService
    {
        /// <summary>
        /// Asynchronous method to get all firms 
        /// </summary>
        /// <returns>Task<IEnumerable<FirmServiceModel>></returns>
        Task<IEnumerable<FirmServiceModel>> GetAllAsync();

        /// <summary>
        /// Get all firms that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<FirmServiceModel></returns>
        public IQueryable<FirmServiceModel> GetAllByPredicateAsync
            (string sortType, string value);

        /// <summary>
        /// Get matching firms paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns>Task<IEnumerable<FirmServiceModel>></returns>
        public Task<IEnumerable<FirmServiceModel>> GetAllByPredicatePagedAsync(
            string sortType, string value,
            int pageSize, int pageNumber);

        /// <summary>
        /// Get a firm by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<FirmServiceModel></returns>
        public Task<FirmServiceModel> GetByIdAsync(int id);

        /// <summary>
        /// Method to get count of sorted paginated firms
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <returns>Task<int></returns>
        public Task<int> GetPredicatedCountAsync(string sortType, string value);

        /// <summary>
        /// Add firm method (Asynchronous)
        /// </summary>
        /// <param name="firm">Firm to add</param>
        /// <returns>(void)</returns>
        public Task AddAsync(FirmServiceModel firm);

        /// <summary>
        /// Update firm method (Asynchronous)
        /// </summary>
        /// <param name="firm">Firm to update</param>
        /// <returns>(void)</returns>
        public Task UpdateAsync(FirmServiceModel firm);

        /// <summary>
        /// Delete firm method (Asynchronous)
        /// </summary>
        /// <param name="firm">Firm to delete</param>
        /// <returns>(void)</returns>
        public Task DeleteAsync(FirmServiceModel firm);

        /// <summary>
        /// Delete range firms method (Asynchronous)
        /// </summary>
        /// <param name="firms">Firms</param>
        /// <returns></returns>
        public Task DeleteRangeAsync(IEnumerable<FirmServiceModel> firms);
    }
}
