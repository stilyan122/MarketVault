namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

    /// <summary>
    /// Interface responsible for document type service
    /// </summary>
    public interface IDocumentTypeService
    {
        /// <summary>
        /// Asynchronous method to get all document types 
        /// </summary>
        /// <returns>Task<IEnumerable<DocumentTypeServiceModel>></returns>
        Task<IEnumerable<DocumentTypeServiceModel>> GetAllAsync();
    }
}
