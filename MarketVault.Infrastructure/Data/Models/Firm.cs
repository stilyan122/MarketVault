namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.FirmConstants;

    /// <summary>
    /// Firm Entity
    /// </summary>
    [Comment("Firm Entity Class")]
    public class Firm
    {
        /// <summary>
        /// Firm Identificator
        /// </summary>
        [Comment("Firm Identificator")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Firm Name
        /// </summary>
        [Comment("Firm Name")]
        [MaxLength(NameMaxLength)]
        [Required]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Firm Phone Number
        /// </summary>
        [Comment("Firm Phone Number")]
        [StringLength(PhoneNumberLength, MinimumLength = PhoneNumberLength)]
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Firm Email
        /// </summary>
        [Comment("Firm Email")]
        [MaxLength(EmailMaxLength)]
        [Required]
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Firm Responsible Person Name
        /// </summary>
        [Comment("Firm Responsible Person Name")]
        [MaxLength(ResponsiblePersonNameMaxLength)]
        [Required]
        public string ResponsiblePersonName { get; set; } = string.Empty;

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

        /// <summary>
        /// Collection with CounterParty Entities
        /// </summary>
        public IEnumerable<CounterParty> CounterParties { get; set; }
            = new List<CounterParty>();
    }
}
