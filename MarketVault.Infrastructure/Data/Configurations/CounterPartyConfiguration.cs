namespace MarketVault.Infrastructure.Data.Configurations
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// Configuration Class - CounterParty Entity
    /// </summary>
    public class CounterPartyConfiguration : IEntityTypeConfiguration<CounterParty>
    {
        /// <summary>
        /// Configure method
        /// </summary>
        /// <param name="builder">Entity Type Builder</param>
        public void Configure(EntityTypeBuilder<CounterParty> builder)
        {
            var counterParties = new List<CounterParty>
            {
                new CounterParty()
                {
                    Id = 1,
                    Name = "Martinez Capital Management",
                    BankIBAN = "GB29NWBK60161331926819",
                    ValueAddedTaxLawId = "GB123456789",
                    VATNumber = "GB123456789",
                    BankCode = "ABCDEFGH",
                    BankId = 1,
                    FirmId = 2
                },
                new CounterParty()
                {
                    Id = 2,
                    Name = "Brown Investment Partners",
                    BankIBAN = "SE3550000000054910000003",
                    ValueAddedTaxLawId = "NL123456789B01",
                    VATNumber = "NL123456789B01",
                    BankCode = "123456789012345678",
                    BankId = 2,
                    FirmId = 3
                },
                new CounterParty()
                {
                    Id = 3,
                    Name = "Taylor Financial Solutions",
                    BankIBAN = "IT60X0542811101000000123456",
                    ValueAddedTaxLawId = "FR12345678901",
                    VATNumber = "FR12345678901",
                    BankCode = "12345678",
                    BankId = 3,
                    FirmId = 4
                },
                new CounterParty()
                {
                    Id = 4,
                    Name = "Greenberg Holdings Ltd",
                    BankIBAN = "ESX1234567X",
                    ValueAddedTaxLawId = "SE123456789012",
                    VATNumber = "SE123456789012",
                    BankCode = "DE12345678901234567890",
                    BankId = 4,
                    FirmId = 5
                },
                new CounterParty()
                {
                    Id = 5,
                    Name = "Hall Trading Corporation",
                    BankIBAN = "CHE-123.456.789",
                    ValueAddedTaxLawId = "IT12345678901",
                    VATNumber = "IT12345678901",
                    BankCode = "01234-567",
                    BankId = 5,
                    FirmId = 1,
                }
            };

            builder.HasData(counterParties);
        }
    }
}
