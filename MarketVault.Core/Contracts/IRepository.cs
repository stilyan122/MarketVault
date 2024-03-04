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
        /// Add entity method (Asynchronous)
        /// </summary>
        /// <param name="entity">Entity to add</param>
        /// <returns>(void)</returns>
        Task AddAsync(TEntity entity);

        /// <summary>
        /// Update entity method (Asynchronous)
        /// </summary>
        /// <param name="entity">Entity to update</param>
        /// <returns>(void)</returns>
        Task UpdateAsync(TEntity entity);

        /// <summary>
        /// Delete entity method (Asynchronous)
        /// </summary>
        /// <param name="entity">Entity to remove</param>
        /// <returns>(void)</returns>
        Task DeleteAsync(TEntity entity);

        /// <summary>
        /// Asynchronous method for saving changes in DB
        /// </summary>
        /// <returns>Integer to mark whether the changes have been made</returns>
        Task<int> SaveChangesAsync();
    }
}
