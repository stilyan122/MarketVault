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
