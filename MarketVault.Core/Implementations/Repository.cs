namespace MarketVault.Core.Implementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Data;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Repository class that implements IRepository interface
    /// </summary>
    /// <typeparam name="TEntity">DB Entity</typeparam>
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// DB Context to use
        /// </summary>
        private readonly DbContext context = null!;

        /// <summary>
        /// Current DbSet
        /// </summary>
        private readonly DbSet<TEntity> dbSet = null!;

        private readonly ILogger<Repository<TEntity>> logger = null!;

        /// <summary>
        /// Default constructor (DI)
        /// </summary>
        /// <param name="context">Db Context from outside</param>
        /// <param name="logger">Logger</param>
        public Repository(
            ApplicationDbContext context,
            ILogger<Repository<TEntity>> logger)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
            this.logger = logger;
        }

        /// <summary>
        /// Asynchronous add method
        /// </summary>
        /// <param name="entity">Entity to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(TEntity entity)
        {
            logger.LogInformation("Add async method in repository invoked.");

            await this.dbSet.AddAsync(entity);
            await this.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for getting all entities
        /// </summary>
        /// <returns>IQueryable<TEntity></returns>
        public IQueryable<TEntity> All()
        {
            logger.LogInformation("All method in repository invoked.");

            return this.dbSet;
        }

        /// <summary>
        /// Asynchronous method for getting all entities as read-only
        /// </summary>
        /// <returns>IQueryable<TEntity></returns>
        public IQueryable<TEntity> AllAsReadOnly()
        {
            logger.LogInformation("All read only method in repository invoked.");

            return this.dbSet.AsNoTracking();
        }

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <returns>Task<TEntity?></returns>
        public async Task<TEntity?> GetByIdAsync(int id)
        {
            logger.LogInformation("Get by id async method in repository invoked.");

            return await this.dbSet.FindAsync(id);
        }

        /// <summary>
        /// Asynchronous method for saving changes in DB
        /// </summary>
        /// <returns>Task<int> whether the changes have been saved</returns>
        public async Task<int> SaveChangesAsync()
        {
            logger.LogInformation("Save changes async method in repository invoked.");

            return await this.context.SaveChangesAsync();
        }
    }
}
