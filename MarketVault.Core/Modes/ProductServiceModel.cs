namespace MarketVault.Core.Modes
{
    /// <summary>
    /// Service model used for product entity
    /// </summary>
    public class ProductServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string CashRegisterName { get; set; } = string.Empty;

        public int ArticleNumber { get; set; }

        public int NomenclatureNumber { get; set; }

        public int CodeForScales { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }

        public decimal Quantity { get; set; }

        public string Description { get; set; } = string.Empty;

        public string ItemGroupName { get; set; } = string.Empty;

        public int ItemGroupId { get; set; }

        public List<string> Barcodes { get; set; } = new List<string>();

        public DateTime DateAdded { get; set; }

        public DateTime DateModified { get; set; }

        public string Measure { get; set; } = string.Empty;
    }
}
