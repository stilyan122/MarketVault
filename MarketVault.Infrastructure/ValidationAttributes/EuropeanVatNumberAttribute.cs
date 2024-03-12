namespace MarketVault.Infrastructure.ValidationAttributes
{
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    public class EuropeanVatNumberAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, 
            ValidationContext validationContext)
        {
            if (value != null)
            {
                string vatNumber = value.ToString() ?? "";

                // European VAT number format: [Country Code][Digits]
                // Example: DE123456789 (Germany)
                if (!Regex.IsMatch(vatNumber, @"^[A-Z]{2}\d{9}$"))
                {
                    return new ValidationResult("Invalid European VAT number format. (ex: BG123456789)");
                }

                // Validate country code against a list of valid EU member states
                string countryCode = vatNumber.Substring(0, 2);
                if (!IsValidEUCountryCode(countryCode))
                {
                    return new ValidationResult("Invalid European VAT number country code.");
                }
            }
            return ValidationResult.Success;
        }

        private static bool IsValidEUCountryCode(string countryCode)
        {
            // Sample list of EU member states
            List<string> euCountries = new List<string>
            { "AT", "BE", "BG", "HR", "CY", "CZ", "DK", 
                "EE", "FI", "FR", "DE", "GR", "HU", "IE",
                "IT", "LV", "LT", "LU", "MT", "NL", "PL", 
                "PT", "RO", "SK", "SI", "ES", "SE" };

            return euCountries.Contains(countryCode);
        }
    }
}
