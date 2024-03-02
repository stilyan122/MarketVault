namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuration Class - Bank Entity
    /// </summary>
    public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            var banks = new List<Bank>
            {
                new Bank()
                {
                    Id = 1,
                    AddressId = 1,
                    Name = "Evergreen Financial"
                },
                new Bank()
                {
                    Id = 2,
                    AddressId = 4,
                    Name = "Summit Savings & Loan"
                },
                new Bank()
                {
                    Id = 3,
                    AddressId = 5,
                    Name = "Golden Gate Bank"
                },
                new Bank()
                {
                    Id = 4,
                    AddressId = 2,
                    Name = "Heritage Community Bank"
                },
                new Bank()
                {
                    Id = 5,
                    AddressId = 4,
                    Name = "Unity Bank"
                }
            };

            builder.HasData(banks);
        }
    }
}
