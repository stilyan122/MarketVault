namespace MarketVault.Models.Product
{
    public class ProductViewModel
    {
        public string Name { get; set; } = string.Empty;

        public string CashRegisterName { get; set; } = string.Empty;

        public int CodeForScales { get; set; }

        public decimal PurchasePrice { get; set; }

        public decimal SalePrice { get; set; }

        public decimal Quantity { get; set; }

        public string ItemGroupName { get; set; } = string.Empty;

        public List<string> Barcodes { get; set; } = new List<string>();

        public DateTime DateAdded { get; set; }

        public DateTime DateModified { get; set; }

        public string Measure { get; set; } = string.Empty;
    }
}
