namespace MarketVault.Core.Contracts
{
    /// <summary>
    /// Interface for Repository Pattern
    /// </summary>
    /// <typeparam name="TEntity">Entity from DB</typeparam>
    public interface IRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Get All method
        /// </summary>
        /// <returns>IQueryable<TEntity></returns>
        IQueryable<TEntity> All();

        /// <summary>
        /// Asynchronous method for getting all entities as read-only
        /// </summary>
        /// <returns>IQueryable<TEntity></returns>
        IQueryable<TEntity> AllAsReadOnly();

        /// <summary>
        /// Add entity method (Asynchronous)
        /// </summary>
        /// <param name="entity">Entity to add</param>
        /// <returns>(void)</returns>
        Task AddAsync(TEntity entity);

        /// <summary>
        /// Asynchronous method for getting an entity by id
        /// </summary>
        /// <returns>Task<TEntity?></returns>
         Task<TEntity?> GetByIdAsync(int id);

        /// <summary>
        /// Asynchronous method for saving changes in DB
        /// </summary>
        /// <returns>Integer to mark whether the changes have been made</returns>
        Task<int> SaveChangesAsync();
    }
}
