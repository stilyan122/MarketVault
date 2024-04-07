namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

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
    }
}
