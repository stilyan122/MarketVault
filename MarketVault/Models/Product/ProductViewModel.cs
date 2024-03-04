namespace MarketVault.Models.Product
{
    /// <summary>
    /// Product view model
    /// </summary>
    public class ProductViewModel
    {
        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Product cash register name
        /// </summary>
        public string CashRegisterName { get; set; } = string.Empty;

        /// <summary>
        /// Product code for scales
        /// </summary>
        public int CodeForScales { get; set; }

        /// <summary>
        /// Product purchase price
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Product sale price
        /// </summary>
        public decimal SalePrice { get; set; }

        /// <summary>
        /// Product quantity
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Product item group name
        /// </summary>
        public string ItemGroupName { get; set; } = string.Empty;

        /// <summary>
        /// Product date when added
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// Product date when last modified
        /// </summary>
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Product measure value
        /// </summary>
        public string Measure { get; set; } = string.Empty;
    }
}
