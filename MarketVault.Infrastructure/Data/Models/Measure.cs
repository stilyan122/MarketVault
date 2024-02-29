namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
       .DataConstants.MeasureConstants;

    /// <summary>
    /// Measure Entity
    /// </summary>
    [Comment("Measure Entity Class")]
    public class Measure
    {
        /// <summary>
        /// Measure Identificator
        /// </summary>
        [Comment("Measure Identificator")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Measure Name
        /// </summary>
        [Comment("Measure Name")]
        [MaxLength(NameMaxLength)]
        [Required]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Bool flag - if the value can be a decimal number
        /// </summary>
        [Comment("Bool flag - decimal")]
        public bool CanBeDecimal { get; set; } = true;

        /// <summary>
        /// Flag for activity 
        /// </summary>
        [Comment("Flag for activity")]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Collection with entities from the mapping table - ProductsMeasures
        /// </summary>
        public IEnumerable<ProductMeasure> ProductsMeasures { get; set; }
            = new List<ProductMeasure>();
    }
}
