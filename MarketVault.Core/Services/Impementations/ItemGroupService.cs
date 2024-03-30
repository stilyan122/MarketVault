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

    public class ItemGroupService : IItemGroupService
    {
        /// <summary>
        /// Item Group repository
        /// </summary>
        private readonly IRepository<ItemGroup> repository = null!;

        /// <summary>
        /// Product service
        /// </summary>
        private readonly IProductService productService = null!;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<ItemGroupService> logger = null!;

        /// <summary>
        /// Default constructor, injection of Item Group repository, product service and logger (DI)
        /// </summary>
        /// <param name="repository">Item Group repository</param>
        /// <param name="productService">IProductService</param>
        /// <param name="logger">Logger</param>
        public ItemGroupService(
            IRepository<ItemGroup> repository,
            IProductService productService,
            ILogger<ItemGroupService> logger)
        {
            this.repository = repository;
            this.productService = productService;
            this.logger = logger;
        }

        /// <summary>
        /// Get all item group method (Asynchronous)
        /// </summary>
        /// <returns>Task<IEnumerable<ItemGroupServiceModel>></returns>
        public async Task<IEnumerable<ItemGroupServiceModel>> GetAllAsync()
        {
            logger.LogInformation("All async method in item group service invoked.");

            return await this.repository
                .All()
                .AsNoTracking()
                .ProjectToItemGroupServiceModel()
                .ToListAsync();
        }

        /// <summary>
        /// Get all item groups that match a condition as IQueryable
        /// </summary>
        /// <returns>IQueryable<ItemGroupServiceModel></returns>
        public IQueryable<ItemGroupServiceModel> GetAllByPredicateAsync
            (string sortType, string value)
        {
            logger.LogInformation("All by predicate async method in item group service invoked.");

            var entities = this.repository
                .AllAsReadOnly()
                .AsNoTracking()
                .ProjectToItemGroupServiceModel();

            logger.LogWarning("Potential exception to be thrown.");

            try
            {
                entities = sortType switch
                {
                    "Name" => entities.Where(e => e.Name.ToLower().Contains(value.ToLower())),
                    "Products Count" when int.TryParse(value, out var productsCount) =>
                        entities.Where(e => e.Products.Count() == productsCount),
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
        /// Get matching item groups paginated (Asynchronous)
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <param name="pageSize">Size of 1 page</param>
        /// <param name="pageNumber">Number of page</param>
        /// <returns></returns>
        public async Task<IEnumerable<ItemGroupServiceModel>> GetAllByPredicatePagedAsync(
            string sortType, string value,
            int pageSize, int pageNumber)
        {
            logger.LogInformation("All by predicate paged async method in item group service invoked.");

            var entities = this.GetAllByPredicateAsync(sortType, value);

            return await entities
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToListAsync();
        }

        /// <summary>
        /// Method to get count of sorted paginated item groups
        /// </summary>
        /// <param name="sortType">Sort type used to sort them</param>
        /// <param name="value">Sort value</param>
        /// <returns>Task<int></returns>
        public async Task<int> GetPredicatedCountAsync(string sortType, string value)
        {
            logger.LogInformation("Get predicated count async method in item group service invoked.");

            return await this.GetAllByPredicateAsync(sortType, value)
                .CountAsync();
        }

        /// <summary>
        /// Add item group method (Asynchronous)
        /// </summary>
        /// <param name="itemGroup">Item group to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(ItemGroupServiceModel itemGroup)
        {
            logger.LogInformation("Add async method in item group service invoked.");

            var entity = ConvertToEntityModel(itemGroup);

            await this.repository.AddAsync(entity);
        }

        /// <summary>
        /// Delete item group method (Asynchronous)
        /// </summary>
        /// <param name="itemGroup">Product to delete</param>
        /// <returns>(void)</returns>
        public async Task DeleteAsync(ItemGroupServiceModel itemGroup)
        {
            logger.LogInformation("Delete async method in item group service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeItemGroupStatements()
                .Where(p => p.Id == itemGroup.Id)
                .FirstOrDefaultAsync()
                ?? throw new EntityNotFoundException("Item group not found");

            entity.IsActive = false;

            var products = await this.productService.GetAllAsync();
            foreach (ProductServiceModel product in products
                .Where(p => p.ItemGroupId == itemGroup.Id))
            {
                await this.productService.DeleteAsync(product);
            }

            await this.repository.SaveChangesAsync();
        }

        /// <summary>
        /// Get a item group by a given id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to get</param>
        /// <returns>Task<ItemGroupServiceModel></returns>
        public async Task<ItemGroupServiceModel> GetByIdAsync(int id)
        {
            logger.LogInformation("Get by id async method in item group service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeItemGroupStatements()
                .Where(p => p.Id == id)
                .FirstOrDefaultAsync() ??
                throw new EntityNotFoundException("Item group is null!");

            var serviceModel = new ItemGroupServiceModel()
            {
                Id = entity.Id,
                Name = entity.Name,
                Products = entity.Products.Select(p => new ProductServiceModel()
                {
                    ArticleNumber = p.ArticleNumber,
                    Barcodes = p.Barcodes.ToList(),
                    DateAdded = p.DateAdded,
                    Description = p.Description,
                    DateModified = p.DateModified,
                    CashRegisterName = p.CashRegisterName,
                    CodeForScales = p.CodeForScales,
                    Id = p.Id,
                    ItemGroupId = p.ItemGroupId,
                    ItemGroup = p.ItemGroup,
                    Measure = p.ProductsMeasures.Any() ? p.ProductsMeasures.First().Measure : new Measure(),
                    MeasureId = p.ProductsMeasures.Any() ? p.ProductsMeasures.First().MeasureId : 0,
                    Name = p.Name,
                    NomenclatureNumber = p.NomenclatureNumber,
                    PurchasePrice = p.PurchasePrice,
                    Quantity = p.Quantity,
                    SalePrice = p.SalePrice
                })
            };

            return serviceModel;
        }

        /// <summary>
        /// Update item group method (Asynchronous)
        /// </summary>
        /// <param name="product">Item group to update</param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(ItemGroupServiceModel itemGroup)
        {
            logger.LogInformation("Update async method in item group service invoked.");

            logger.LogWarning("Potential entity not found exception to be thrown.");

            var entity = await this.repository
                .All()
                .UseIncludeItemGroupStatements()
                .Where(p => p.Id == itemGroup.Id)
                .FirstOrDefaultAsync()
                ?? throw new EntityNotFoundException("Item group not found");

            entity.Name = itemGroup.Name;

            await this.repository.SaveChangesAsync();
        }

        /// <summary>
        /// Helper private method used for converting to entity model
        /// </summary>
        /// <param name="itemGroup"></param>
        /// <returns></returns>
        private static ItemGroup ConvertToEntityModel
            (ItemGroupServiceModel itemGroup)
        {
            return new ItemGroup()
            {
                Name = itemGroup.Name
            };
        }
    }
}
