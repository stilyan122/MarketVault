namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Extensions;
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
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
        /// Logger
        /// </summary>
        private readonly ILogger<CounterPartyService> logger = null!;

        /// <summary>
        /// Default constructor, injection of Counter Party repository and logger (DI)
        /// </summary>
        /// <param name="repository">Counter Party repository</param>
        /// <param name="logger">Logger</param>
        public CounterPartyService(
            IRepository<CounterParty> repository,
            ILogger<CounterPartyService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        /// <summary>
        /// Add counter party method (Asynchronous)
        /// </summary>
        /// <param name="counterParty">Counter party to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(CounterPartyServiceModel counterParty)
        {
            logger.LogInformation("Add async method in counter party service invoked.");

            var entity = new CounterParty()
            {
                BankId = counterParty.BankId,
                FirmId = counterParty.FirmId,
                Name = counterParty.Name,
                BankCode = counterParty.BankCode,
                VATNumber = counterParty.VATNumber,
                ValueAddedTaxLawId = counterParty.ValueAddedTaxLawId,
                BankIBAN = counterParty.BankIBAN
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
            logger.LogInformation("Delete async method in counter party service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeCounterPartyStatements()
                .Where(p => p.Id == counterParty.Id)
                .FirstOrDefaultAsync()
                ?? throw new EntityNotFoundException("Counter party not found");

            entity.IsActive = false;

            await this.repository.SaveChangesAsync();
        }

        /// <summary>
        /// Get counter parties count (Asynchronous)
        /// </summary>
        /// <returns>Task<int></returns>
        public async Task<int> GetCountAsync()
        {
            return await this.repository.AllAsReadOnly()
                .Where(cp => cp.IsActive)
                .CountAsync();
        }

        /// <summary>
        /// Get all counter parties method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<CounterPartyServiceModel>></returns>
        public async Task<IEnumerable<CounterPartyServiceModel>> GetAllAsync()
        {
            logger.LogInformation("All async method in counter party service invoked.");

            var entities = await this.repository
                .All()
                .UseIncludeCounterPartyStatements()
                .AsNoTracking()
                .Select(cp => new CounterPartyServiceModel()
                {
                    Id = cp.Id,
                    Bank = cp.Bank,
                    BankCode = cp.BankCode,
                    BankIBAN = cp.BankIBAN,
                    Firm = cp.Firm,
                    FirmId = cp.FirmId,
                    BankId = cp.BankId,
                    Name = cp.Name,
                    ValueAddedTaxLawId = cp.ValueAddedTaxLawId,
                    VATNumber = cp.VATNumber
                })
                .ToListAsync();

            return entities;
        }

        /// <summary>
        /// Get all counter parties that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<CounterPartyServiceModel></returns>
        public IQueryable<CounterPartyServiceModel> GetAllByPredicateAsync
            (string sortType, string value)
        {
            logger.LogInformation("All by predicate async method in counter party service invoked.");

            var entities = this.repository
                .AllAsReadOnly()
                .AsNoTracking()
                .ProjectToCounterPartyServiceModel();

            entities = sortType switch
            {
                "Name" => entities.Where(e => e.Name.ToLower().Contains(value.ToLower())),
                "Bank Code" => entities.Where(e => e.BankCode.ToLower().Contains(value.ToLower())),
                "Bank IBAN" => entities.Where(e => e.BankIBAN.ToLower().Contains(value.ToLower())),
                "Bank Name" => entities.Where(e => e.Bank.Name.ToLower().Contains(value.ToLower())),
                "Firm Name" => entities.Where(e => e.Firm.Name.ToLower().Contains(value.ToLower())),
                _ => entities.Where(e => e.Id == 0)
            };

            return entities;
        }

        /// <summary>
        /// Get matching counter parties paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns>Task<IEnumerable<CounterPartyServiceModel>></returns>
        public async Task<IEnumerable<CounterPartyServiceModel>> GetAllByPredicatePagedAsync(
            string sortType, string value,
            int pageSize, int pageNumber)
        {
            logger.LogInformation("All by predicate paged async method in counter party service invoked.");

            var entities = this.
                GetAllByPredicateAsync(sortType, value);

            return await entities
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
        }

        /// <summary>
        /// Get a counter party by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<CounterPartyServiceModel></returns>
        public async Task<CounterPartyServiceModel> GetByIdAsync(int id)
        {
            logger.LogInformation("Get by id async method in counter party service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeCounterPartyStatements()
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync() ??
                throw new EntityNotFoundException("Counter party is null!");

            var serviceModel = new CounterPartyServiceModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Bank = entity.Bank,
                Firm = entity.Firm,
                FirmId = entity.FirmId,
                BankId = entity.BankId,
                BankCode = entity.BankCode,
                BankIBAN = entity.BankIBAN,
                ValueAddedTaxLawId = entity.ValueAddedTaxLawId,
                VATNumber = entity.VATNumber
            };

            return serviceModel;
        }

        /// <summary>
        /// Method to get count of sorted paginated counter parties
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <returns>Task<int></returns>
        public async Task<int> GetPredicatedCountAsync(string sortType, string value)
        {
            logger.LogInformation("Get predicated count async method in counter party service invoked.");

            return await this.GetAllByPredicateAsync(sortType, value)
                .CountAsync();
        }

        /// <summary>
        /// Update counter party method (Asynchronous)
        /// </summary>
        /// <param name="counterParty">Counter party to update</param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(CounterPartyServiceModel counterParty)
        {
            logger.LogInformation("All async method in counter party service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeCounterPartyStatements()
                .Where(p => p.Id == counterParty.Id)
                .FirstOrDefaultAsync()
                ?? throw new EntityNotFoundException("Counter party not found");

            entity.Name = counterParty.Name;
            entity.BankId = counterParty.BankId;
            entity.FirmId = counterParty.FirmId;
            entity.VATNumber = counterParty.VATNumber;
            entity.ValueAddedTaxLawId = counterParty.ValueAddedTaxLawId;
            entity.BankCode = counterParty.BankCode;
            entity.BankIBAN = counterParty.BankIBAN;

            await this.repository.SaveChangesAsync();
        }
    }
}
