namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuration Class - ProductOperation Entity
    /// </summary>
    public class ProductOperationConfiguration :
        IEntityTypeConfiguration<ProductOperation>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<ProductOperation> builder)
        {
            var productsOperations = new List<ProductOperation>();
            var random = new Random();
            int counter = 1;
            int current = 0;

            for (int i = 0; i < 50; i++)
            {
                var productOperation = new ProductOperation()
                {
                    ProductId = i+1,
                    OperationId = counter
                };
                current++;

                if (current == 10)
                {
                    counter++;
                    current = 0;
                }

                productsOperations.Add(productOperation);
            }


            builder.HasData(productsOperations);
        }
    }
}
