namespace MarketVault.Data
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// App DB Context
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext
    {
        /// <summary>
        /// Default DB Context Constructor
        /// </summary>
        /// <param name="options">DB Context options</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductMeasure>()
                .HasKey(pm => new
                {
                    pm.MeasureId,
                    pm.ProductId
                });

            base.OnModelCreating(builder);
        }
    }
}
