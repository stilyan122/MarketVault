namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuration Class - DocumentType Entity
    /// </summary>
    public class DocumentTypeConfiguration : IEntityTypeConfiguration<DocumentType>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            var documentTypes = new List<DocumentType>()
            {
                new DocumentType()
                {
                    Id = 1,
                    Name = "Tax invoice"
                },
                new DocumentType()
                {
                    Id = 2,
                    Name = "Bill of goods"
                },
                new DocumentType()
                {
                    Id = 3,
                    Name = "Waste"
                },
                new DocumentType()
                {
                    Id = 4,
                    Name = "Discharge"
                }
            };

            builder.HasData(documentTypes);
        }
    }
}
