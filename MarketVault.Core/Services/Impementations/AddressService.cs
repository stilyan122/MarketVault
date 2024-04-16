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
    /// Address Service
    /// </summary>
    public class AddressService : IAddressService
    {
        /// <summary>
        /// Firm repository
        /// </summary>
        private readonly IRepository<Address> repository = null!;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<AddressService> logger = null!;

        /// <summary>
        /// Default constructor, injection of Address repository and logger (DI)
        /// </summary>
        /// <param name="repository">Address repository</param>
        /// <param name="logger">Logger</param>
        public AddressService(IRepository<Address> repository,
            ILogger<AddressService> logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        /// <summary>
        /// Get all addresses method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<AddressServiceModel>></returns>
        public async Task<IEnumerable<AddressServiceModel>> GetAllAsync()
        {
            logger.LogInformation("All async method in address service invoked.");

            return await this.repository
                .AllAsReadOnly()
                .ProjectToAddressServiceModel()
                .ToListAsync();
        }

        /// <summary>
        /// Get addresses count (Asynchronous)
        /// </summary>
        /// <returns>Task<int></returns>
        public async Task<int> GetCountAsync()
        {
            return await this.repository.AllAsReadOnly()
                .Where(a => a.IsActive)
                .CountAsync();
        }

        /// <summary>
        /// Get all addresses that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<AddressServiceModel></returns>
        public IQueryable<AddressServiceModel> GetAllByPredicateAsync
            (string sortType, string value)
        {
            logger.LogInformation("All by predicate async method in address service invoked.");

            var entities = this.repository
                .AllAsReadOnly()
                .AsNoTracking()
                .ProjectToAddressServiceModel();

            logger.LogWarning("Potential exception to be thrown.");
                
            entities = sortType switch
             {
                 "Town Name" => entities.Where(e => e.TownName.ToLower().Contains(value.ToLower())),
                 "Street Name" => entities.Where(e => e.StreetName.ToLower().Contains(value.ToLower())),
                 "Street Number" => entities.Where(e => e.StreetNumber.ToLower().Contains(value.ToLower())),
                 _ => entities.Where(e => e.Id == 0)
             };

             return entities;
        }

        /// <summary>
        /// Get matching addresses paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns>Task<IEnumerable<FirmServiceModel>></returns>
        public async Task<IEnumerable<AddressServiceModel>> GetAllByPredicatePagedAsync(
            string sortType, string value,
            int pageSize, int pageNumber)
        {
            logger.LogInformation("All by predicate paged async method in address service invoked.");
            var entities = this.GetAllByPredicateAsync(sortType, value);

            return await entities
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
        }

        /// <summary>
        /// Get an address by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<AddressServiceModel></returns>
        public async Task<AddressServiceModel> GetByIdAsync(int id)
        {
            logger.LogInformation("Get by id async method in address service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeAddressStatements()
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync() ??
                throw new EntityNotFoundException("Address is null!");

            var serviceModel = new AddressServiceModel()
            {
                Id = entity.Id,
                StreetName = entity.StreetName,
                TownName = entity.TownName,
                StreetNumber = entity.StreetNumber
            };

            return serviceModel;
        }

        /// <summary>
        /// Method to get count of sorted paginated addresses
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <returns>Task<int></returns>
        public async Task<int> GetPredicatedCountAsync(string sortType, string value)
        {
            logger.LogInformation("Predicated count async method in address service invoked.");

            return await this.GetAllByPredicateAsync(sortType, value)
                .CountAsync();
        }

        /// <summary>
        /// Add address method (Asynchronous)
        /// </summary>
        /// <param name="address">Address to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(AddressServiceModel address)
        {
            logger.LogInformation("Add async method in address service invoked.");

            var entity = new Address()
            {
                StreetName = address.StreetName,
                StreetNumber = address.StreetNumber,
                TownName = address.TownName
            };

            await this.repository.AddAsync(entity);
        }

        /// <summary>
        /// Delete address method (Asynchronous)
        /// </summary>
        /// <param name="address">Address to delete</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(AddressServiceModel address)
        {
            logger.LogInformation("Delete async method in address service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeAddressStatements()
                .Where(p => p.Id == address.Id)
                .FirstOrDefaultAsync()
                ?? throw new EntityNotFoundException("Address not found");

            entity.IsActive = false;

            await this.repository.SaveChangesAsync();
        }

        /// <summary>
        /// Update address method (Asynchronous)
        /// </summary>
        /// <param name="address">Firm to update</param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(AddressServiceModel address)
        {
            logger.LogInformation("Update async method in address service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeAddressStatements()
                .Where(p => p.Id == address.Id)
                .FirstOrDefaultAsync()
                ?? throw new EntityNotFoundException("Address not found");

            entity.StreetNumber = address.StreetNumber;
            entity.StreetName = address.StreetName;
            entity.TownName = address.TownName;

            await this.repository.SaveChangesAsync();
        }
    }
}
