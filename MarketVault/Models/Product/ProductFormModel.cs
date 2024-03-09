namespace MarketVault.Models.Product
{
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ProductConstants;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ExceptionMessagesConstants;
    using MarketVault.Models.ItemGroup;
    using MarketVault.Models.Measure;

    /// <summary>
    /// Product form model
    /// </summary>
    public class ProductFormModel
    {
        /// <summary>
        /// Product name
        /// </summary>
        [Required(ErrorMessage = ProductNameRequiredExceptionMessage)]
        [StringLength(NameMaxLength, 
            MinimumLength = NameMinLength,
            ErrorMessage = ProductNameLengthExceptionMessage)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Product cash register name
        /// </summary>
        [Required(ErrorMessage = ProductCashRegisterNameRequiredExceptionMessage)]
        [StringLength(CashRegisterNameMaxLength,
            MinimumLength = CashRegisterNameMinLength,
            ErrorMessage = ProductCashRegisterNameLengthExceptionMessage)]
        public string CashRegisterName { get; set; } = string.Empty;

        /// <summary>
        /// Product code for scales
        /// </summary>
        public int CodeForScales { get; set; }

        /// <summary>
        /// Product sale price
        /// </summary>
        [Required(ErrorMessage = ProductSalePriceRequiredExceptionMessage)]
        [Range(NumberMinValue,
            NumberMaxValue,
            ErrorMessage = ProductSalePriceRangeExceptionMessage)]
        public decimal SalePrice { get; set; }

        /// <summary>
        /// Product purchase price
        /// </summary>
        [Required(ErrorMessage = ProductPurchasePriceRequiredExceptionMessage)]
        [Range(NumberMinValue,
            NumberMaxValue,
            ErrorMessage = ProductPurchasePriceRangeExceptionMessage)]
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Product description
        /// </summary>
        [Required(ErrorMessage = ProductDescriptionRequiredExceptionMessage)]
        [StringLength(DescriptionMaxLength,
            MinimumLength = DescriptionMinLength,
            ErrorMessage = ProductDescriptionLengthExceptionMessage)]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Product item group id
        /// </summary>
        [Required(ErrorMessage = ProductItemGroupRequiredExceptionMessage)]
        public int ItemGroupId { get; set; }

        /// <summary>
        /// Product item groups
        /// </summary>
        public IEnumerable<ItemGroupViewModel> ItemGroups { get; set; }
            = new List<ItemGroupViewModel>();

        /// <summary>
        /// Product measure id
        /// </summary>
        [Required(ErrorMessage = ProductMeasureRequiredExceptionMessage)]
        public int MeasureId { get; set; }

        /// <summary>
        /// Product measures
        /// </summary>
        public IEnumerable<MeasureViewModel> Measures { get; set; }
            = new List<MeasureViewModel>();

        /// <summary>
        /// Product barcodes
        /// </summary>
        public List<string> Barcodes { get; set; }
            = new List<string>();
    }
}
