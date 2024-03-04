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
    /// Counter party service
    /// </summary>
    public class CounterPartyService : ICounterPartyService
    {
        /// <summary>
        /// Counter party repository
        /// </summary>
        private readonly IRepository<CounterParty> repository = null!;

        /// <summary>
        /// Default constructor, injection of Counter Party repository (DI)
        /// </summary>
        /// <param name="repository">Counter Party repository</param>
        public CounterPartyService(IRepository<CounterParty> repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Add counter party method (Asynchronous)
        /// </summary>
        /// <param name="counterParty">Counter party to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(CounterPartyServiceModel counterParty)
        {
            var entity = new CounterParty()
            {

            };

            await this.repository.AddAsync(entity);
        }

        /// <summary>
        /// Delete counter party method (Asynchronous)
        /// </summary>
        /// <param name="counterParty">Counter party to delete</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(CounterPartyServiceModel counterParty)
        {
            var entity = new CounterParty()
            {

            };

            await this.repository.DeleteAsync(entity);
        }

        /// <summary>
        /// Get all counter parties method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<CounterPartyServiceModel>></returns>
        public async Task<IEnumerable<CounterPartyServiceModel>> GetAllAsync()
        {
            var entities = await this.repository
                .All()
                .Include(cp => cp.Bank)
                .Include(cp => cp.Firm)
                .Where(cp => cp.IsActive)
                .AsNoTracking()
                .Select(cp => new CounterPartyServiceModel()
                {
                    Id = cp.Id,
                    Bank = cp.Bank,
                    BankCode = cp.BankCode,
                    BankIBAN = cp.BankIBAN,
                    Firm = cp.Firm,
                    Name = cp.Name,
                    ValueAddedTaxLawId = cp.ValueAddedTaxLawId,
                    VATNumber = cp.VATNumber
                })
                .ToListAsync();

            return entities;
        }

        /// <summary>
        /// Update counter party method (Asynchronous)
        /// </summary>
        /// <param name="counterParty">Counter party to update</param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(CounterPartyServiceModel counterParty)
        {
            var entity = new CounterParty()
            {

            };

            await this.repository.UpdateAsync(entity);
        }
    }
}
