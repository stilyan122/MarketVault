namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ItemGroupConstants;

    /// <summary>
    /// ItemGroup Entity
    /// </summary>
    [Comment("ItemGroup Entity Class")]
    public class ItemGroup
    {
        /// <summary>
        /// ItemGroup Identificator
        /// </summary>
        [Comment("ItemGroup Identificator")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// ItemGroup Name
        /// </summary>
        [Comment("ItemGroup Name")]
        [MaxLength(NameMaxLength)]
        [Required]
        public string Name { get; set; } = string.Empty;

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
