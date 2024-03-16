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
    /// Address Service
    /// </summary>
    public class AddressService : IAddressService
    {
        /// <summary>
        /// Firm repository
        /// </summary>
        private readonly IRepository<Address> repository = null!;

        /// <summary>
        /// Default constructor, injection of Address repository (DI)
        /// </summary>
        /// <param name="repository">Address repository</param>
        public AddressService(IRepository<Address> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Get all addresses method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<AddressServiceModel>></returns>
        public async Task<IEnumerable<AddressServiceModel>> GetAllAsync()
        {
            return await this.repository
                .All()
                .AsNoTracking()
                .Select(a => new AddressServiceModel()
                {
                    Id = a.Id,
                    StreetName = a.StreetName,
                    StreetNumber = a.StreetNumber,
                    TownName = a.TownName
                })
                .ToListAsync();
        }
    }
}
