namespace MarketVault.Models.Product
{
    /// <summary>
    /// View model for details about product entity
    /// </summary>
    public class ProductDetailsViewModel : ProductViewModel
    {
        public string Description { get; set; } = string.Empty;

        public int ArticleNumber { get; set; }

        public int NomenclatureNumber { get; set; }
    }
}
