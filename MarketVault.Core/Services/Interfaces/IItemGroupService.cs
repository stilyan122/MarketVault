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
    }
}
