namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;
    using MarketVault.Infrastructure.Data.Models;

    /// <summary>
    /// Interface responsible for operation service
    /// </summary>
    public interface IOperationService
    {
        /// <summary>
        /// Asynchronous method for adding an Operation entity
        /// </summary>
        /// <param name="operation">OperationServiceModel service model</param>
        /// <param name="model">ProductOperation service model</param>
        /// <returns>(void)</returns>
        Task AddAsync(OperationServiceModel operation, 
            ProductOperationServiceModel model);

        /// <summary>
        /// Asynchronous method for getting operations for a user
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <returns>Task<IEnumerable<OperationServiceModel>></returns>
        Task<IEnumerable<OperationServiceModel>> GetUserOperationsAsync(string userId);
    }
}
