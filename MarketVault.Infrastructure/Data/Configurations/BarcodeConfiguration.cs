namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System.Text;

    /// <summary>
    /// Configuration Class - Barcode Entity
    /// </summary>
    public class BarcodeConfiguration : IEntityTypeConfiguration<Barcode>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<Barcode> builder)
        {
            var barcodes = new List<Barcode>();
            var values = new List<string>();
            var random = new Random();
            PopulateBarcodes(values);

            for (int i = 1; i <= 150; i++)
            {
                barcodes.Add(new Barcode()
                {
                    Id = i,
                    Value = values[i - 1],
                    ProductId = random.Next(1, 151)
                });
            }

            builder.HasData(barcodes);
        }

        private static void PopulateBarcodes(List<string> values)
        {
            for (int i = 0; i < 150; i++)
            {
                Random random = new Random();
                StringBuilder barcodeNumber = new StringBuilder();

                barcodeNumber.Append(new string
                    (char.Parse(random.Next(1, 10).ToString()), 12));

                values.Add(barcodeNumber.ToString());
            }
        }
    }
}
