namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuration Class - Firm Entity
    /// </summary>
    public class FirmConfiguration : IEntityTypeConfiguration<Firm>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<Firm> builder)
        {
            var firms = new List<Firm>() 
            {
                new Firm()
                {
                    Id = 1,
                    AddressId = 1,
                    Email = "contact@horizonbank.com",
                    Name = "Horizon",
                    PhoneNumber = "+1 (555) 123-4567",
                    ResponsiblePersonName = "Jennifer Anderson"
                },
                new Firm()
                {
                    Id = 2,
                    AddressId = 5,
                    Email = "contact@heritagecommunitybank.com",
                    Name = "Heritage Community",
                    PhoneNumber = "+1 (555) 901-2345",
                    ResponsiblePersonName = "Olivia Rodriguez"
                },
                new Firm()
                {
                    Id = 3,
                    AddressId = 2,
                    Email = "help@goldengate.com",
                    Name = "Golden Gate",
                    PhoneNumber = " +1 (555) 678-9012",
                    ResponsiblePersonName = " Alexander Lee"
                },
                new Firm()
                {
                    Id = 4,
                    AddressId = 2,
                    Email = "feedback@unity.com",
                    Name = "Unity",
                    PhoneNumber = "+1 (555) 012-3456",
                    ResponsiblePersonName = "Matthew White"
                },
                new Firm()
                {
                    Id = 5,
                    AddressId = 4,
                    Email = "customerservice@libertynational.com",
                    Name = "Liberty National",
                    PhoneNumber = "+1 (555) 567-8901",
                    ResponsiblePersonName = "Emily Smith"
                }
            };

            builder.HasData(firms);
        }
    }
}
