namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuration Class - Measure Entity
    /// </summary>
    public class MeasureConfiguration : IEntityTypeConfiguration<Measure>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<Measure> builder)
        {
            var measures = new List<Measure>
            {
                new Measure()
                {
                    Id = 1,
                    Name = "kg",
                    CanBeDecimal = true
                },
                new Measure()
                {
                    Id = 2,
                    Name = "no",
                    CanBeDecimal = false
                }
            };

            builder.HasData(measures);
        }
    }
}
