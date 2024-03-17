namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Extensions;
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
                .AsNoTracking()
                .ProjectToBankServiceModel()
                .ToListAsync();
        }

        /// <summary>
        /// Get all banks that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<FirmServiceModel></returns>
        public IQueryable<BankServiceModel> GetAllByPredicateAsync
            (string sortType, string value)
        {
            var entities = this.repository
                .AllReadOnly()
                .AsNoTracking()
                .ProjectToBankServiceModel();

            try
            {
                entities = sortType switch
                {
                    "Name" => entities.Where(e => e.Name.ToLower().Contains(value.ToLower())),
                    "Address" => entities.Where(e => e
                    .Address.TownName.ToLower()
                    .Contains(value.ToLower()) || e.Address
                    .StreetName.ToLower().Contains(value.ToLower()) ||
                    e.Address.StreetNumber.ToLower().Contains(value.ToLower())),
                    _ => entities.Where(e => e.Id == 0)
                };

                return entities;
            }
            catch (Exception)
            {
                entities = entities.Where(e => e.Id == 0);
            }

            return entities;
        }

        /// <summary>
        /// Get matching banks paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns>Task<IEnumerable<BankServiceModel>></returns>
        public async Task<IEnumerable<BankServiceModel>> GetAllByPredicatePagedAsync(
            string sortType, string value,
            int pageSize, int pageNumber)
        {
            var entities = this.GetAllByPredicateAsync(sortType, value);

            return await entities
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
        }

        /// <summary>
        /// Get a bank by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<BankServiceModel></returns>
        public async Task<BankServiceModel> GetByIdAsync(int id)
        {
            var entity = await this.repository
                .All()
                .UseIncludeBankStatements()
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync() ??
                throw new ArgumentNullException("Entity is null!");

            var serviceModel = new BankServiceModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Address = entity.Address,
                AddressId = entity.AddressId
            };

            return serviceModel;
        }

        /// <summary>
        /// Method to get count of sorted paginated banks
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <returns>Task<int></returns>
        public async Task<int> GetPredicatedCount(string sortType, string value)
        {
            return await this.GetAllByPredicateAsync(sortType, value)
                .CountAsync();
        }

        /// <summary>
        /// Add bank method (Asynchronous)
        /// </summary>
        /// <param name="bank">Bank to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(BankServiceModel bank)
        {
            var entity = new Bank()
            {
                AddressId = bank.AddressId,
                Name = bank.Name
            };

            await this.repository.AddAsync(entity);
        }

        /// <summary>
        /// Delete bank method (Asynchronous)
        /// </summary>
        /// <param name="bank">Bank to delete</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(BankServiceModel bank)
        {
            var entity = await this.repository
                .All()
                .UseIncludeBankStatements()
                .Where(p => p.Id == bank.Id)
                .FirstOrDefaultAsync()
                ?? throw new ArgumentException("Entity not found");

            entity.IsActive = false;

            await this.repository.SaveChangesAsync();
        }

        /// <summary>
        /// Update bank method (Asynchronous)
        /// </summary>
        /// <param name="bank">Bank to update</param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(BankServiceModel bank)
        {
            var entity = await this.repository
                .All()
                .UseIncludeBankStatements()
                .Where(p => p.Id == bank.Id)
                .FirstOrDefaultAsync()
                ?? throw new ArgumentException("Entity not found");

            entity.Name = bank.Name;
            entity.AddressId = bank.AddressId;

            await this.repository.SaveChangesAsync();
        }
    }
}
