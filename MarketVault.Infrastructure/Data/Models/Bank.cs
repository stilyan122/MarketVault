namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.BankConstants;

    /// <summary>
    /// Bank Entity
    /// </summary>
    [Comment("Bank Entity Class")]
    public class Bank
    {
        /// <summary>
        /// Bank Identificator
        /// </summary>
        [Comment("Bank Identificator")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Bank Name
        /// </summary>
        [Comment("Bank Name")]
        [MaxLength(NameMaxLength)]
        [Required]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Flag for activity 
        /// </summary>
        [Comment("Flag for activity")]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// AddressId - foreign key
        /// </summary>
        [Comment("AddressId - FK")]
        [ForeignKey(nameof(Address))]
        [Required]
        public int AddressId { get; set; }

        /// <summary>
        /// Address Entity
        /// </summary>
        public Address Address { get; set; } = null!;
    }
}
