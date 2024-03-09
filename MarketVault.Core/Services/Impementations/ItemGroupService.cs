namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ItemGroupService : IItemGroupService
    {
        /// <summary>
        /// Item Group repository
        /// </summary>
        private readonly IRepository<ItemGroup> repository = null!;

        /// <summary>
        /// Default constructor, injection of Item Group repository (DI)
        /// </summary>
        /// <param name="repository">Item Group repository</param>
        public ItemGroupService(IRepository<ItemGroup> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Get all item group method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<ItemGroupServiceModel>></returns>
        public async Task<IEnumerable<ItemGroupServiceModel>> GetAllAsync()
        {
            return await this.repository
                .All()
                .Select(ig => new ItemGroupServiceModel() 
                {
                    Id = ig.Id,
                    Name = ig.Name
                })
                .ToListAsync();
        }
    }
}
