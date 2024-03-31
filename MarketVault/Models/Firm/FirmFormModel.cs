namespace MarketVault.Models.Firm
{
    using MarketVault.Core.Contracts;
    using MarketVault.Models.Address;
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ExceptionMessagesConstants;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.FirmConstants;

    /// <summary>
    /// Firm form model
    /// </summary>
    public class FirmFormModel : IUrlDetailModel
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

        /// <summary>
        /// Model Information - for URL
        /// </summary>
        public string Information { get; set; } = string.Empty;
    }
}
