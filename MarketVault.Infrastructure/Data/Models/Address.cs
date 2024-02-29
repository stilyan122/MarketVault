namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.AddressConstants;

    /// <summary>
    /// Address Entity
    /// </summary>
    [Comment("Address Entity Class")]
    public class Address
    {
        /// <summary>
        /// Address Identificator
        /// </summary>
        [Comment("Address Identificator")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Address Town Name
        /// </summary>
        [Comment("Address Town Name")]
        [MaxLength(TownNameMaxLength)]
        [Required]
        public string TownName { get; set; } = string.Empty;

        /// <summary>
        /// Address Street Name
        /// </summary>
        [Comment("Address Street Name")]
        [MaxLength(StreetNameMaxLength)]
        [Required]
        public string StreetName { get; set; } = string.Empty;

        /// <summary>
        /// Address Street Number
        /// </summary>
        [Comment("Address Street Number")]
        [MaxLength(StreetNumberMaxValue)]
        [Required]
        public string StreetNumber { get; set; } = string.Empty;

        /// <summary>
        /// Flag for activity 
        /// </summary>
        [Comment("Flag for activity")]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Collection with Bank Entities
        /// </summary>
        public IEnumerable<Bank> Banks { get; set; } = 
            new List<Bank>();

        /// <summary>
        /// Collection with Bank Entities
        /// </summary>
        public IEnumerable<Firm> Firms { get; set; } =
            new List<Firm>();
    }
}
