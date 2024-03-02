namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuration Class - ProductMeasure Entity
    /// </summary>
    public class ProductMeasureConfiguration : 
        IEntityTypeConfiguration<ProductMeasure>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<ProductMeasure> builder)
        {
            var productsMeasures = new List<ProductMeasure>();
            var measures = new List<int>()
            {
                2,2,2,2,2,2,2,2,2,2,
                2,2,2,2,2,2,2,2,2,2,
                2,2,2,2,2,2,2,2,2,2,
                1,1,1,1,1,1,1,1,1,1,
                1,1,1,1,1,1,1,1,1,1,
                2,2,2,2,2,2,2,2,2,2,
                2,2,2,2,2,2,2,2,2,2,
                2,2,2,2,2,2,2,2,2,2,
                1,1,1,1,1,1,1,1,1,1,   
                1,1,1,1,1,1,1,1,1,1,   
                1,1,1,1,1,1,1,1,1,1,   
                1,1,1,1,1,1,1,1,1,1,   
                1,1,1,1,1,1,1,1,1,1,   
                1,1,1,1,1,1,1,1,1,1,   
                1,1,1,1,1,1,1,1,1,1,   
            };

            for (int i = 0; i < 150; i++)
            {
                var productMeasure = new ProductMeasure()
                {
                    ProductId = i + 1,
                    MeasureId = measures[i]
                };

                productsMeasures.Add(productMeasure);
            }

            builder.HasData(productsMeasures);
        }
    }
}
