namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

    /// <summary>
    /// Interface responsible for address service
    /// </summary>
    public interface IAddressService
    {
        //// <summary>
        /// Get all addresses method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<AddressServiceModel>></returns>
        public Task<IEnumerable<AddressServiceModel>> GetAllAsync();

        /// <summary>
        /// Get all addresses that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<AddressServiceModel></returns>
        public IQueryable<AddressServiceModel> GetAllByPredicateAsync
            (string sortType, string value);

        /// <summary>
        /// Get matching addresses paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns>Task<IEnumerable<FirmServiceModel>></returns>
        public Task<IEnumerable<AddressServiceModel>> GetAllByPredicatePagedAsync(
            string sortType, string value,
            int pageSize, int pageNumber);

        /// <summary>
        /// Get an address by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<AddressServiceModel></returns>
        public Task<AddressServiceModel> GetByIdAsync(int id);

        /// <summary>
        /// Method to get count of sorted paginated addresses
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <returns>Task<int></returns>
        public Task<int> GetPredicatedCountAsync(string sortType, string value);

        /// <summary>
        /// Add address method (Asynchronous)
        /// </summary>
        /// <param name="address">Address to add</param>
        /// <returns>(void)</returns>
        public Task AddAsync(AddressServiceModel address);

        /// <summary>
        /// Delete address method (Asynchronous)
        /// </summary>
        /// <param name="address">Address to delete</param>
        /// <returns>(void)</returns>
        public Task DeleteAsync(AddressServiceModel address);

        /// <summary>
        /// Update address method (Asynchronous)
        /// </summary>
        /// <param name="address">Firm to update</param>
        /// <returns>(void)</returns>
        public Task UpdateAsync(AddressServiceModel address);
    }
}
