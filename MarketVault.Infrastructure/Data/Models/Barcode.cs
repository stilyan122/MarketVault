namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
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
        /// Collection with Product entities
        /// </summary>
        public IEnumerable<Product> Products { get; set; }
            = new List<Product>();
    }
}
