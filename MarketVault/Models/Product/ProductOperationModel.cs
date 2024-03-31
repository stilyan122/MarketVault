namespace MarketVault.Models.Product
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Product operation model
    /// </summary>
    public class ProductOperationModel
    {
        /// <summary>
        /// Model id
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Model quantity
        /// </summary>
        [Required]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Model sale price
        /// </summary>
        [Required]
        public decimal SalePrice { get; set; }

        /// <summary>
        /// Model purchase price
        /// </summary>
        [Required]
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Model collection of products
        /// </summary>
        public IEnumerable<ProductDetailsViewModel> Products { get; set; }
            = new List<ProductDetailsViewModel>();
    }
}
