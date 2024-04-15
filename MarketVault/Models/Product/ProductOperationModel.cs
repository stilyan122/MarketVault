namespace MarketVault.Models.Product
{
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ProductConstants;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ExceptionMessagesConstants;

    /// <summary>
    /// Product operation model
    /// </summary>
    public class ProductOperationModel
    {
        /// <summary>
        /// Model id
        /// </summary>
        [Required(ErrorMessage = ProductRequiredExceptionMessage)]
        public int? Id { get; set; }

        /// <summary>
        /// Model quantity
        /// </summary>
        [Required(ErrorMessage = ProductQuantityExceptionMessage)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Model cash register name
        /// </summary>
        public string CashRegisterName { get; set; } = string.Empty;

        /// <summary>
        /// Product sale price
        /// </summary>
        [Required(ErrorMessage = ProductSalePriceRequiredExceptionMessage)]
        [Range(
            typeof(decimal),
            NumberMinPriceValue,
            NumberMaxPriceValue,
            ErrorMessage = ProductSalePriceRangeExceptionMessage,
            ConvertValueInInvariantCulture = true)]
        [RegularExpression(PriceFormat,
            ErrorMessage = ProductSalePriceFormatExceptioMessage)]
        public decimal SalePrice { get; set; }

        /// <summary>
        /// Product purchase price
        /// </summary>
        [Required(ErrorMessage = ProductPurchasePriceRequiredExceptionMessage)]
        [Range(
            typeof(decimal),
            NumberMinPriceValue,
            NumberMaxPriceValue,
            ErrorMessage = ProductPurchasePriceRangeExceptionMessage,
            ConvertValueInInvariantCulture = true)]
        [RegularExpression(PriceFormat,
            ErrorMessage = ProductPurchasePriceFormatExceptioMessage)]
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Model collection of products
        /// </summary>
        public IEnumerable<ProductDetailsViewModel> Products { get; set; }
            = new List<ProductDetailsViewModel>();
    }
}
