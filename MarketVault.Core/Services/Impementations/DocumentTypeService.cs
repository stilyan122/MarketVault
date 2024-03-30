namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Document Type service
    /// </summary>
    public class DocumentTypeService : IDocumentTypeService
    {
        /// <summary>
        /// DocumentType repository
        /// </summary>
        private readonly IRepository<DocumentType> repository = null!;

        /// <summary>
        /// Default constructor, injection of Document Type repository (DI)
        /// </summary>
        /// <param name="repository">Document type repository</param>
        public DocumentTypeService(IRepository<DocumentType> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Get all document types method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<DocumentTypeServiceModel>></returns>
        public async Task<IEnumerable<DocumentTypeServiceModel>> GetAllAsync()
        {
            return await this.repository
                .All()
                .Select(dt => new DocumentTypeServiceModel
                {
                    Id = dt.Id,
                    Name = dt.Name
                })
                .ToListAsync();
        }
    }
}
