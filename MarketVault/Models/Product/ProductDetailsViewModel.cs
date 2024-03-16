namespace MarketVault.Models.Product
{
    /// <summary>
    /// Detailed product view model
    /// </summary>
    public class ProductDetailsViewModel : ProductViewModel
    {
        /// <summary>
        /// Product description
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Product article number
        /// </summary>
        public int ArticleNumber { get; set; }

        /// <summary>
        /// Product nomenclature number
        /// </summary>
        public int NomenclatureNumber { get; set; }

        /// <summary>
        /// Product collection of barcodes
        /// </summary>
        public IEnumerable<string> Barcodes { get; set; } = new List<string>();
    }
}
