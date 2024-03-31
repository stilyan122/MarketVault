namespace MarketVault.Models.ItemGroup
{
    using MarketVault.Core.Contracts;
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ExceptionMessagesConstants;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ItemGroupConstants;

    /// <summary>
    /// Item group form model
    /// </summary>
    public class ItemGroupFormModel : IUrlDetailModel
    {
        /// <summary>
        /// Item group name name
        /// </summary>
        [Required(ErrorMessage = ItemGroupNameRequiredExceptionMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = ItemGroupNameLengthExceptionMessage)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Model Information - for URL
        /// </summary>
        public string Information { get; set; } = string.Empty;
    }
}
