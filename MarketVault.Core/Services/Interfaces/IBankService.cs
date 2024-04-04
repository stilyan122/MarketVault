namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

    /// <summary>
    /// Interface responsible for bank service
    /// </summary>
    public interface IBankService
    {
        /// <summary>
        /// Asynchronous method to get all banks 
        /// </summary>
        /// <returns>Task<IEnumerable<BankServiceModel>></returns>
        Task<IEnumerable<BankServiceModel>> GetAllAsync();

        /// <summary>
        /// Get banks count (Asynchronous)
        /// </summary>
        /// <returns>Task<int></returns>
        public Task<int> GetCountAsync();

        /// <summary>
        /// Get all banks that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<FirmServiceModel></returns>
        public IQueryable<BankServiceModel> GetAllByPredicateAsync
            (string sortType, string value);

        /// <summary>
        /// Get matching banks paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns>Task<IEnumerable<BankServiceModel>></returns>
        public Task<IEnumerable<BankServiceModel>> GetAllByPredicatePagedAsync(
            string sortType, string value,
            int pageSize, int pageNumber);

        /// <summary>
        /// Get a bank by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<BankServiceModel></returns>
        public Task<BankServiceModel> GetByIdAsync(int id);

        /// <summary>
        /// Method to get count of sorted paginated banks
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <returns>Task<int></returns>
        public Task<int> GetPredicatedCountAsync(string sortType, string value);

        /// <summary>
        /// Add bank method (Asynchronous)
        /// </summary>
        /// <param name="bank">Bank to add</param>
        /// <returns>(void)</returns>
        public Task AddAsync(BankServiceModel bank);

        /// <summary>
        /// Delete bank method (Asynchronous)
        /// </summary>
        /// <param name="bank">Bank to delete</param>
        /// <returns>(void)</returns>
        public Task DeleteAsync(BankServiceModel bank);

        /// <summary>
        /// Delete range banks method (Asynchronous)
        /// </summary>
        /// <param name="banks">Banks</param>
        /// <returns></returns>
        public Task DeleteRangeAsync(IEnumerable<BankServiceModel> banks);

        /// <summary>
        /// Update bank method (Asynchronous)
        /// </summary>
        /// <param name="bank">Bank to update</param>
        /// <returns>(void)</returns>
        public Task UpdateAsync(BankServiceModel bank);
    }
}
