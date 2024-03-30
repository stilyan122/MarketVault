namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;

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
        /// Logger
        /// </summary>
        private readonly ILogger<DocumentTypeService> logger = null!;

        /// <summary>
        /// Default constructor, injection of Document Type repository and logger (DI)
        /// </summary>
        /// <param name="repository">Document type repository</param>
        /// <param name="logger">Logger</param>
        public DocumentTypeService(
            IRepository<DocumentType> repository,
            ILogger<DocumentTypeService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        /// <summary>
        /// Get all document types method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<DocumentTypeServiceModel>></returns>
        public async Task<IEnumerable<DocumentTypeServiceModel>> GetAllAsync()
        {
            logger.LogInformation("All async method in document type service invoked.");

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
