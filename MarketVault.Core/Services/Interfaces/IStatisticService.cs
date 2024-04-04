namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

    /// <summary>
    /// Interface responsible for statistic service
    /// </summary>
    public interface IStatisticService
    {
        /// <summary>
        /// Asynchronous method for getting the statistic service model
        /// </summary>
        /// <returns>Task<StatisticServiceModel></returns>
        public Task<StatisticServiceModel> GetStatisticServiceModelAsync();
    }
}
