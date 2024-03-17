namespace MarketVault.Models.Address
{

    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.AddressConstants;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ExceptionMessagesConstants;

    /// <summary>
    /// Address form model
    /// </summary>
    public class AddressFormModel
    {
        /// <summary>
        /// Address town name
        /// </summary>
        [Required(ErrorMessage = AddressTownNameRequiredExceptionMessage)]
        [StringLength(TownNameMaxLength,
            MinimumLength = TownNameMinLength,
            ErrorMessage = AddressTownNameLengthExceptionMessage)]
        public string TownName { get; set; } = string.Empty;

        /// <summary>
        /// Address street name
        /// </summary>
        [Required(ErrorMessage = AddressStreetNameRequiredExceptionMessage)]
        [StringLength(StreetNameMaxLength,
            MinimumLength = StreetNameMinLength,
            ErrorMessage = AddressStreetNameLengthExceptionMessage)]
        public string StreetName { get; set; } = string.Empty;

        /// <summary>
        /// Address street number
        /// </summary>
        [Required(ErrorMessage = AddressStreetNumberRequiredExceptionMessage)]
        [StringLength(StreetNumberMaxValue,
            MinimumLength = StreetNumberMinValue,
            ErrorMessage = AddressStreetNumberLengthExceptionMessage)]
        public string StreetNumber { get; set; } = string.Empty;
    }
}
