namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

    /// <summary>
    /// Interface responsible for counter party service
    /// </summary>
    public interface ICounterPartyService
    {
        /// <summary>
        /// Asynchronous method to get all counter parties 
        /// </summary>
        /// <returns>Task<IEnumerable<CounterPartyServiceModel>></returns>
        Task<IEnumerable<CounterPartyServiceModel>> GetAllAsync();

        /// <summary>
        /// Get all counter parties that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<CounterPartyServiceModel></returns>
        public IQueryable<CounterPartyServiceModel> GetAllByPredicateAsync
            (string sortType, string value);

        /// <summary>
        /// Get matching counter parties paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns>Task<IEnumerable<CounterPartyServiceModel>></returns>
        public Task<IEnumerable<CounterPartyServiceModel>> GetAllByPredicatePagedAsync(
            string sortType, string value,
            int pageSize, int pageNumber);

        /// <summary>
        /// Get a counter party by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<CounterPartyServiceModel></returns>
        public Task<CounterPartyServiceModel> GetByIdAsync(int id);

        /// <summary>
        /// Method to get count of sorted paginated counter parties
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <returns>Task<int></returns>
        public Task<int> GetPredicatedCountAsync(string sortType, string value);

        /// <summary>
        /// Asynchronous method for adding a counter party 
        /// </summary>
        /// <param name="counterParty">Counter party service model</param>
        /// <returns>(void)</returns>
        Task AddAsync(CounterPartyServiceModel counterParty);

        /// <summary>
        /// Asynchronous method for updating a counter party 
        /// </summary>
        /// <param name="counterParty">Counter party service model</param>
        /// <returns>(void)</returns>
        Task UpdateAsync(CounterPartyServiceModel counterParty);

        /// <summary>
        /// Asynchronous for deleting a counter party 
        /// </summary>
        /// <param name="counterParty">Counter party service model</param>
        /// <returns>(void)</returns>
        Task DeleteAsync(CounterPartyServiceModel counterParty);
    }
}
