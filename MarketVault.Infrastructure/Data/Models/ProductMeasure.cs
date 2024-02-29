namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// ProductMeasure Entity - mapping table
    /// </summary>
    [Comment("ProductMeasure Entity Class")]
    public class ProductMeasure
    {
        /// <summary>
        /// Product Id
        /// </summary>
        [Comment("Product Id")]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        /// <summary>
        /// Product Entity
        /// </summary>
        public Product Product { get; set; } = null!;

        /// <summary>
        /// Measure Id
        /// </summary>
        [Comment("Measure Id")]
        [ForeignKey(nameof(Measure))]
        public int MeasureId { get; set; }

        /// <summary>
        /// Measure Entity
        /// </summary>
        public Measure Measure { get; set; } = null!;
    }
}
