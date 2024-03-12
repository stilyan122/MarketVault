﻿namespace MarketVault.Core.Implementations
{
    using MarketVault.Core.Contracts;
    using MarketVault.Data;
    using Microsoft.EntityFrameworkCore;
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

        /// <summary>
        /// Default constructor (DI)
        /// </summary>
        /// <param name="context">Db Context from outside</param>
        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Asynchronous add method
        /// </summary>
        /// <param name="entity">Entity to add</param>
        /// <returns>(void)</returns>
        public async Task AddAsync(TEntity entity)
        {
            await this.dbSet.AddAsync(entity);
            await this.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for getting all entities
        /// </summary>
        /// <returns>IQueryable<TEntity></returns>
        public IQueryable<TEntity> All()
            => this.dbSet;

        /// <summary>
        /// Asynchronous method for removing an entity
        /// </summary>
        /// <param name="entity">Entity to remove</param>
        public async Task DeleteAsync(TEntity entity)
        {
            this.dbSet.Remove(entity);
            await this.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for saving changes in DB
        /// </summary>
        /// <returns>Task<int> whether the changes have been saved</returns>
        public async Task<int> SaveChangesAsync()
        {
            return await this.context.SaveChangesAsync();
        }

        /// <summary>
        /// Asynchronous method for updating an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>(void)</returns>
        public async Task UpdateAsync(TEntity entity)
        {
            this.context.Attach(entity);
            this.context.Update(entity);
            await this.SaveChangesAsync();
        }
    }
}
