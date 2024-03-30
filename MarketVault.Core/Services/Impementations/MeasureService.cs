namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Measure service
    /// </summary>
    public class MeasureService : IMeasureService
    {
        /// <summary>
        /// Measure repository
        /// </summary>
        private readonly IRepository<Measure> repository = null!;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<MeasureService> logger = null!;

        /// <summary>
        /// Default constructor, injection of Measure repository (DI)
        /// </summary>
        /// <param name="repository">Measure repository</param>
        /// <param name="logger">Logger</param>
        public MeasureService(
            IRepository<Measure> repository,
            ILogger<MeasureService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        /// <summary>
        /// Get all measures method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<MeasureServiceModel>></returns>
        public async Task<IEnumerable<MeasureServiceModel>> GetAllAsync()
        {
            logger.LogInformation("All async method in measure service invoked.");

            return await this.repository
                .All()
                .Select(m => new MeasureServiceModel()
                {
                    Id = m.Id,
                    Value = m.Name
                })
                .ToListAsync();
        }
    }
}
