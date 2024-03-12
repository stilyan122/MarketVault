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
    }
}
