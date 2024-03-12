namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class BankService : IBankService
    {
        /// <summary>
        /// Bank repository
        /// </summary>
        private readonly IRepository<Bank> repository = null!;

        /// <summary>
        /// Default constructor, injection of Bank repository (DI)
        /// </summary>
        /// <param name="repository">Bank repository</param>
        public BankService(IRepository<Bank> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Get all banks method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<BankServiceModel>></returns>
        public async Task<IEnumerable<BankServiceModel>> GetAllAsync()
        {
            return await this.repository
                .All()
                .Where(b => b.IsActive)
                .Include(b => b.Address)
                .AsNoTracking()
                .Select(b => new BankServiceModel()
                {
                    Address = b.Address,
                    AddressId = b.AddressId,
                    Id = b.Id,
                    Name = b.Name
                })
                .ToListAsync();
        }
    }
}
