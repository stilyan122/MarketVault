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
        /// Model price
        /// </summary>
        public decimal Price { get; set; } 
    }
}
