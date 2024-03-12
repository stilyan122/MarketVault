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
    }
}
