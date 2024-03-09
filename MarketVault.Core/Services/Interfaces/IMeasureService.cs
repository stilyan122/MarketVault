namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

    /// <summary>
    /// Interface responsible for measure service
    /// </summary>
    public interface IMeasureService
    {
        /// <summary>
        /// Asynchronous method to get all measures 
        /// </summary>
        /// <returns>Task<IEnumerable<MeasureServiceModel>></returns>
        Task<IEnumerable<MeasureServiceModel>> GetAllAsync();
    }
}
