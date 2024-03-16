namespace MarketVault.Models.Product
{
    /// <summary>
    /// Product delete form model
    /// </summary>
    public class ProductDeleteFormModel
    {
        /// <summary>
        /// Product id
        /// </summary>
        public int Id { get; set; }

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
        /// Product sale price
        /// </summary>
        public decimal SalePrice { get; set; }

        /// <summary>
        /// Product purchase price
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Product description
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Product item group
        /// </summary>
        public string ItemGroup { get; set; } = string.Empty;

        /// <summary>
        /// Product item group id
        /// </summary>
        public int ItemGroupId { get; set; }

        /// <summary>
        /// Product measure
        /// </summary>
        public string Measure { get; set; } = string.Empty;

        /// <summary>
        /// Product measure id
        /// </summary>
        public int MeasureId { get; set; }

        /// <summary>
        /// Product barcodes
        /// </summary>
        public IEnumerable<string> Barcodes { get; set; } =
            new List<string>();
    }
}
