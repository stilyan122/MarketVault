namespace MarketVault.Core.Models
{
    using MarketVault.Infrastructure.Data.Models;

    /// <summary>
    /// Service model used for product entity
    /// </summary>
    public class ProductServiceModel
    {
        /// <summary>
        /// Service model id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Service model name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Service model cash register name
        /// </summary>
        public string CashRegisterName { get; set; } = string.Empty;

        /// <summary>
        /// Service model article number
        /// </summary>
        public int ArticleNumber { get; set; }

        /// <summary>
        /// Service model nomenclature number
        /// </summary>
        public int NomenclatureNumber { get; set; }

        /// <summary>
        /// Service model code for scales
        /// </summary>
        public int CodeForScales { get; set; }

        /// <summary>
        /// Service model purchase price
        /// </summary>
        public decimal PurchasePrice { get; set; }

        /// <summary>
        /// Service model sale price
        /// </summary>
        public decimal SalePrice { get; set; }

        /// <summary>
        /// Service model quantity
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Service model description
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Service model item group
        /// </summary>
        public ItemGroup ItemGroup { get; set; } = null!;

        /// <summary>
        /// Service model item group id
        /// </summary>
        public int ItemGroupId { get; set; }

        /// <summary>
        /// Service model collection with barcodes
        /// </summary>
        public List<Barcode> Barcodes { get; set; } = new List<Barcode>();

        /// <summary>
        /// Service model date when added
        /// </summary>
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// Service model date when last modified
        /// </summary>
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Service model measure
        /// </summary>
        public Measure Measure { get; set; } = null!;

        /// <summary>
        /// Service model measure id
        /// </summary>
        public int MeasureId { get; set; }
    }
}
