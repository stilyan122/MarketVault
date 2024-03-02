namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// ProductOperation Entity - mapping table
    /// </summary>
    [Comment("ProductOperation Entity Class")]
    public class ProductOperation
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
        /// Operation Id
        /// </summary>
        [Comment("Operation Id")]
        [ForeignKey(nameof(Operation))]
        public int OperationId { get; set; }

        /// <summary>
        /// Operation Entity
        /// </summary>
        public Operation Operation { get; set; } = null!;
    }
}
