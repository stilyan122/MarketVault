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
    /// Firm Service
    /// </summary>
    public class FirmService : IFirmService
    {
        /// <summary>
        /// Firm repository
        /// </summary>
        private readonly IRepository<Firm> repository = null!;

        /// <summary>
        /// Counter party service
        /// </summary>
        private readonly ICounterPartyService counterPartyService = null!;

        /// <summary>
        /// Default constructor, injection of Firm repository and service (DI)
        /// </summary>
        /// <param name="repository">Firm repository</param>
        public FirmService(IRepository<Firm> repository,
            ICounterPartyService counterPartyService)
        {
            this.repository = repository;
            this.counterPartyService = counterPartyService;
        }

        /// <summary>
        /// Get all firms method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<FirmServiceModel>></returns>
        public async Task<IEnumerable<FirmServiceModel>> GetAllAsync()
        {
            return await this.repository
                .All()
                .AsNoTracking()
                .ProjectToFirmServiceModel()
                .ToListAsync();
        }

        /// <summary>
        /// Get all firms that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<FirmServiceModel></returns>
        public IQueryable<FirmServiceModel> GetAllByPredicateAsync
            (string sortType, string value)
        {
            var entities = this.repository
                .AllReadOnly()
                .AsNoTracking()
                .ProjectToFirmServiceModel();

            try
            {
                entities = sortType switch
                {
                    "Name" => entities.Where(e => e.Name.ToLower().Contains(value.ToLower())),
                    "Phone Number" => entities.Where(e => e.PhoneNumber.ToLower().Contains(value.ToLower())),
                    "Email" => entities.Where(e => e.Email.ToLower().Contains(value.ToLower())),
                    "Responsible Person Name" => entities.Where(e => e.ResponsiblePersonName.ToLower().Contains(value.ToLower())),
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
        /// Get matching firms paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns>Task<IEnumerable<FirmServiceModel>></returns>
        public async Task<IEnumerable<FirmServiceModel>> GetAllByPredicatePagedAsync(
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
        /// Get a firm by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<FirmServiceModel></returns>
        public async Task<FirmServiceModel> GetByIdAsync(int id)
        {
            var entity = await this.repository
                .All()
                .UseIncludeFirmStatements()
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync() ??
                throw new EntityNotFoundException("Firm is null!");

            var serviceModel = new FirmServiceModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Address = entity.Address,
                AddressId = entity.AddressId,
                Email = entity.Email,
                PhoneNumber = entity.PhoneNumber,
                ResponsiblePersonName = entity.ResponsiblePersonName
            };

            return serviceModel;
        }

        /// <summary>
        /// Method to get count of sorted paginated firms
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
        /// Add firm method (Asynchronous)
        /// </summary>
        /// <param name="firm">Firm to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(FirmServiceModel firm)
        {
            var entity = new Firm()
            {
               AddressId = firm.AddressId,
               Email = firm.Email,
               PhoneNumber = firm.PhoneNumber,
               ResponsiblePersonName = firm.ResponsiblePersonName,
               Name = firm.Name
            };

            await this.repository.AddAsync(entity);
        }

        /// <summary>
        /// Delete firm method (Asynchronous)
        /// </summary>
        /// <param name="firm">Firm to delete</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(FirmServiceModel firm)
        {
            var entity = await this.repository
               .All()
               .UseIncludeFirmStatements()
               .Where(p => p.Id == firm.Id)
               .FirstOrDefaultAsync()
               ?? throw new EntityNotFoundException("Firm not found");

            entity.IsActive = false;

            var counterParties = await this.counterPartyService.GetAllAsync();
            foreach (CounterPartyServiceModel counterParty in counterParties
                .Where(cp => cp.FirmId == entity.Id))
            {
                await this.counterPartyService.DeleteAsync(counterParty);
            }

            await this.repository.SaveChangesAsync();
        }

        /// <summary>
        /// Delete range firms method (Asynchronous)
        /// </summary>
        /// <param name="firms">Firms</param>
        /// <returns></returns>
        public async Task DeleteRangeAsync(IEnumerable<FirmServiceModel> firms)
        {
            foreach (FirmServiceModel firm in firms)
            {
                var entity = await this.repository
                .All()
                .UseIncludeFirmStatements()
                .Where(p => p.Id == firm.Id)
                .FirstOrDefaultAsync()
                ?? throw new EntityNotFoundException("Firm not found");

                entity.IsActive = false;

                var counterParties = await this.counterPartyService.GetAllAsync();
                foreach (CounterPartyServiceModel counterParty in counterParties
                    .Where(cp => cp.FirmId == firm.Id))
                {
                    await this.counterPartyService.DeleteAsync(counterParty);
                }
            }

            await this.repository.SaveChangesAsync();
        }

        /// <summary>
        /// Update firm method (Asynchronous)
        /// </summary>
        /// <param name="firm">Firm to update</param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(FirmServiceModel firm)
        {
            var entity = await this.repository
                .All()
                .UseIncludeFirmStatements()
                .Where(p => p.Id == firm.Id)
                .FirstOrDefaultAsync()
                ?? throw new EntityNotFoundException("Firm not found");

            entity.PhoneNumber = firm.PhoneNumber;
            entity.ResponsiblePersonName = firm.ResponsiblePersonName;
            entity.Name = firm.Name;
            entity.AddressId = firm.AddressId;
            entity.Email = firm.Email;

            await this.repository.SaveChangesAsync();
        }
    }
}
