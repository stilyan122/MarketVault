namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.BarcodeConstants;

    /// <summary>
    /// Barcode Entity
    /// </summary>
    [Comment("Barcode Entity Class")]
    public class Barcode
    {
        /// <summary>
        /// Barcode Identificator
        /// </summary>
        [Comment("Barcode Identificator")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Barcode Value
        /// </summary>
        [Comment("Barcode Value")]
        [MaxLength(ValueMaxLength)]
        [Required]
        public string Value { get; set; } = string.Empty;

        /// <summary>
        /// Flag for activity 
        /// </summary>
        [Comment("Flag for activity")]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// ProductId - foreign key
        /// </summary>
        [Comment("ProductId - FK")]
        [ForeignKey(nameof(Product))]
        [Required]
        public int ProductId { get; set; }

        /// <summary>
        /// Product Entity
        /// </summary>
        public Product Product { get; set; } = null!;
    }
}
