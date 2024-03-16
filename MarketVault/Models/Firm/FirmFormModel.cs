namespace MarketVault.Models.Firm
{
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.FirmConstants;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ExceptionMessagesConstants;
    using MarketVault.Models.Address;

    /// <summary>
    /// Firm form model
    /// </summary>
    public class FirmFormModel
    {
        /// <summary>
        /// Firm name
        /// </summary>
        [Required(ErrorMessage = FirmNameRequiredExceptionMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = FirmNameLengthExceptionMessage)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Firm phone number
        /// </summary>
        [Required(ErrorMessage = FirmPhoneRequiredExceptionMessage)]
        [Phone(ErrorMessage = FirmPhoneRegexExceptionMessage)]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Firm email
        /// </summary>
        [Required(ErrorMessage = FirmEmailRequiredExceptionMessage)]
        [StringLength(EmailMaxLength,
            MinimumLength = EmailMinLength,
            ErrorMessage = FirmEmailLengthExceptionMessage)]
        [EmailAddress(ErrorMessage = FirmEmailRegexExceptionMessage)]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Firm responsible person name
        /// </summary>
        [Required(ErrorMessage = FirmResponsiblePersonRequiredExceptionMessage)]
        [StringLength(ResponsiblePersonNameMaxLength,
            MinimumLength = ResponsiblePersonNameMinLength,
            ErrorMessage = FirmResponsiblePersonLengthExceptionMessage)]
        public string ResponsiblePersonName { get; set; } = string.Empty;

        /// <summary>
        /// Firm address id
        /// </summary>
        [Required(ErrorMessage = FirmAddressRequiredExceptionMessage)]
        public int AddressId { get; set; }

        /// <summary>
        /// Firm addresses
        /// </summary>
        public IEnumerable<AddressViewModel> Addresses { get; set; } =
            new List<AddressViewModel>();
    }
}
