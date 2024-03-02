namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuration Class - Address Entity
    /// </summary>
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            var addresses = new List<Address>()
            {
                new Address()
                {
                    Id = 1,
                    StreetName = "Main Street",
                    StreetNumber = "12, 34",
                    TownName = "London"
                },
                new Address()
                {
                    Id = 2,
                    StreetName = "Local Street",
                    StreetNumber = "45",
                    TownName = "Warsaw"
                },
                new Address()
                {
                    Id = 3,
                    StreetName = "Maple Avenue",
                    StreetNumber = "123",
                    TownName = "Springfield"
                },
                new Address()
                {
                    Id = 4,
                    StreetName = "Oak Street",
                    StreetNumber = "4467, 5645",
                    TownName = "Brooksville"
                },
                new Address()
                {
                    Id = 5,
                    StreetName = "Pine Road",
                    StreetNumber = "789",
                    TownName = "Lakeside"
                }
            };

            builder.HasData(addresses);
        }
    }
}
