namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Extensions;
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
                .ProjectToAddressServiceModel()
                .ToListAsync();
        }

        /// <summary>
        /// Get all addresses that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<AddressServiceModel></returns>
        public IQueryable<AddressServiceModel> GetAllByPredicateAsync
            (string sortType, string value)
        {
            var entities = this.repository
                .AllReadOnly()
                .AsNoTracking()
                .ProjectToAddressServiceModel();

            try
            {
                entities = sortType switch
                {
                    "Town Name" => entities.Where(e => e.TownName.ToLower().Contains(value.ToLower())),
                    "Street Name" => entities.Where(e => e.StreetName.ToLower().Contains(value.ToLower())),
                    "Street Number" => entities.Where(e => e.StreetNumber.ToLower().Contains(value.ToLower())),
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
        public async Task<int> GetPredicatedCount(string sortType, string value)
        {
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
