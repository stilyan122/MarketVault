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
    }
}
