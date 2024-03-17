namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuration Class - ItemGroup Entity
    /// </summary>
    public class ItemGroupConfiguration : IEntityTypeConfiguration<ItemGroup>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<ItemGroup> builder)
        {
            var itemGroups = new List<ItemGroup>
            {
                new ItemGroup()
                {
                    Id = 1,
                    Name = "Ice Cream"
                },
                new ItemGroup()
                {
                    Id = 2,
                    Name = "Fizzy Drinks"
                },
                new ItemGroup()
                {
                    Id = 3,
                    Name = "Alcohol"
                },
                new ItemGroup()
                {
                    Id = 4,
                    Name = "Dairy"
                },
                new ItemGroup()
                {
                    Id = 5,
                    Name = "Sausages"
                },
                new ItemGroup()
                {
                    Id = 6,
                    Name = "Laundry"
                },
                new ItemGroup()
                {
                    Id = 7,
                    Name = "Nuts"
                },
                new ItemGroup()
                {
                    Id = 8,
                    Name = "Cigarettes"
                },
                new ItemGroup()
                {
                    Id = 9,
                    Name = "Bread"
                },
                new ItemGroup()
                {
                    Id = 10,
                    Name = "Fruits and vegetables"
                },
            };

            builder.HasData(itemGroups);
        }
    }
}
