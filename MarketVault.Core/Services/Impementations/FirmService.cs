namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class FirmService : IFirmService
    {
        /// <summary>
        /// Firm repository
        /// </summary>
        private readonly IRepository<Firm> repository = null!;

        /// <summary>
        /// Default constructor, injection of Firm repository (DI)
        /// </summary>
        /// <param name="repository">Firm repository</param>
        public FirmService(IRepository<Firm> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Get all firms method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<FirmServiceModel>></returns>
        public async Task<IEnumerable<FirmServiceModel>> GetAllAsync()
        {
            return await this.repository
                .All()
                .Where(b => b.IsActive)
                .Include(b => b.Address)
                .AsNoTracking()
                .Select(b => new FirmServiceModel()
                {
                    Address = b.Address,
                    AddressId = b.AddressId,
                    Id = b.Id,
                    Name = b.Name,
                    Email = b.Email,
                    PhoneNumber = b.PhoneNumber,
                    ResponsiblePersonName = b.ResponsiblePersonName
                })
                .ToListAsync();
        }
    }
}
