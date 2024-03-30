namespace MarketVault.Models.Product
{
    /// <summary>
    /// Product operation model
    /// </summary>
    public class ProductOperationModel
    {
        /// <summary>
        /// Model id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Model quantity
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Model sale price
        /// </summary>
        public decimal SalePrice { get; set; }

        /// <summary>
        /// Model purchase price
        /// </summary>
        public decimal PurchasePrice { get; set; }
    }
}
