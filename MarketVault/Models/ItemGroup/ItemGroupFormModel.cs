namespace MarketVault.Models.ItemGroup
{
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ItemGroupConstants;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ExceptionMessagesConstants;

    /// <summary>
    /// Item group form model
    /// </summary>
    public class ItemGroupFormModel
    {
        /// <summary>
        /// Item group name name
        /// </summary>
        [Required(ErrorMessage = ItemGroupNameRequiredExceptionMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = ItemGroupNameLengthExceptionMessage)]
        public string Name { get; set; } = string.Empty;
    }
}
