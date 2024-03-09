namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
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
        /// Default constructor, injection of Measure repository (DI)
        /// </summary>
        /// <param name="repository">Measure repository</param>
        public MeasureService(IRepository<Measure> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Get all measures method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<MeasureServiceModel>></returns>
        public async Task<IEnumerable<MeasureServiceModel>> GetAllAsync()
        {
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
