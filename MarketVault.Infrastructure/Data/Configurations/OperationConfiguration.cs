namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuration Class - Operation Entity
    /// </summary>
    public class OperationConfiguration : IEntityTypeConfiguration<Operation>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            var operations = new List<Operation>
            {
                new Operation()
                {
                    Id = 1,
                    TotalSalePriceWithoutVAT = 83.33M,
                    TotalSalePriceWithVAT = 100.00M,
                    TotalPurchasePriceWithoutVAT = 58.33M,
                    TotalPurchasePriceWithVAT = 70.00M,
                    CounterPartyId = 1,
                    DocumentTypeId = 1,
                    UserId = "1db5c825-2f5e-4646-98dc-52bf094f9bf6"
                },
                new Operation()
                {
                    Id = 2,
                    TotalSalePriceWithoutVAT = 62.50M,
                    TotalSalePriceWithVAT = 75.00M,
                    TotalPurchasePriceWithoutVAT = 41.67M,
                    TotalPurchasePriceWithVAT = 50.00M,
                    CounterPartyId = 2,
                    DocumentTypeId = 1,
                    UserId = "1db5c825-2f5e-4646-98dc-52bf094f9bf6"
                },
                new Operation()
                {
                    Id = 3,
                    TotalSalePriceWithoutVAT = 50.00M,
                    TotalSalePriceWithVAT = 60.00M,
                    TotalPurchasePriceWithoutVAT = 33.33M,
                    TotalPurchasePriceWithVAT = 40.00M,
                    CounterPartyId = 3,
                    DocumentTypeId = 2,
                    UserId = "1db5c825-2f5e-4646-98dc-52bf094f9bf6"
                },
                new Operation()
                {
                    Id = 4,
                    TotalSalePriceWithoutVAT = 125.00M,
                    TotalSalePriceWithVAT = 150.00M,
                    TotalPurchasePriceWithoutVAT = 83.33M,
                    TotalPurchasePriceWithVAT = 100.00M,
                    CounterPartyId = 4,
                    DocumentTypeId = 2,
                    UserId = "7bc64720-42fc-4617-bdfa-a7eb00e7e9de"
                },
                new Operation()
                {
                    Id = 5,
                    TotalSalePriceWithoutVAT = 166.67M,
                    TotalSalePriceWithVAT = 200.00M,
                    TotalPurchasePriceWithoutVAT = 125.00M,
                    TotalPurchasePriceWithVAT = 150.00M,
                    CounterPartyId = 5,
                    DocumentTypeId = 1,
                    UserId = "7bc64720-42fc-4617-bdfa-a7eb00e7e9de"
                },
            };

            builder.HasData(operations);
        }
    }
}
