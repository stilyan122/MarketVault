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
        [StringLength(NumberMaxLength,
            MinimumLength = NumberMinLength,
            ErrorMessage = ProductSalePriceRangeExceptionMessage)]
        [RegularExpression(@"^\d+(\.\d+)?(,\d+)?$",
            ErrorMessage = ProductSalePriceFormatExceptioMessage)]
        public string SalePrice { get; set; } = string.Empty;

        /// <summary>
        /// Product purchase price
        /// </summary>
        [Required(ErrorMessage = ProductPurchasePriceRequiredExceptionMessage)]
        [StringLength(NumberMaxLength,
            MinimumLength = NumberMinLength,
            ErrorMessage = ProductPurchasePriceRangeExceptionMessage)]
        [RegularExpression(@"^\d+(\.\d+)?(,\d+)?$", ErrorMessage = ProductPurchasePriceFormatExceptioMessage)]
        public string PurchasePrice { get; set; } = string.Empty;

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
        /// Product barcode max length
        /// </summary>
        public int BarcodeMaxLength { get; set; }

        /// <summary>
        /// Product barcode min length
        /// </summary>
        public int BarcodeMinLength { get; set; }

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
