namespace MarketVault.Infrastructure.Data.Models
{
    using MarketVault.Infrastructure.ValidationAttributes;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static MarketVault.Infrastructure.Constants
       .DataConstants.CounterPartyConstants;

    /// <summary>
    /// CounterParty Entity
    /// </summary>
    [Comment("CounterParty Entity Class")]
    public class CounterParty
    {
        /// <summary>
        /// CounterParty Identificator
        /// </summary>
        [Comment("CounterParty Identificator")]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Flag for activity 
        /// </summary>
        [Comment("Flag for activity")]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// CounterParty VAT Number
        /// </summary>
        [Required]
        [EuropeanVatNumber]
        [MaxLength(VATNumberMaxLength)]
        public string VATNumber { get; set; } = string.Empty;

        /// <summary>
        /// CounterParty ValueAddedTaxLaw Id
        /// </summary>
        [Required]
        [MaxLength(ValueAddedTaxLawIdMaxLength)]
        public string ValueAddedTaxLawId { get; set; } = string.Empty;

        /// <summary>
        /// BankId - foreign key
        /// </summary>
        [Comment("BankId - FK")]
        [ForeignKey(nameof(Bank))]
        [Required]
        public int BankId { get; set; }
        
        /// <summary>
        /// Bank Entity
        /// </summary>
        public Bank Bank { get; set; } = null!;

        /// <summary>
        /// CounterParty Bank Code
        /// </summary>
        [Required]
        public string BankCode { get; set; } = null!;

        /// <summary>
        /// CounterParty Bank IBAN
        /// </summary>
        [Required]
        public string BankIBAN { get; set; } = null!;

        /// <summary>
        /// BankId - foreign key
        /// </summary>
        [Comment("BankId - FK")]
        [ForeignKey(nameof(Firm))]
        [Required]
        public int FirmId { get; set; }

        /// <summary>
        /// Firm Entity
        /// </summary>
        public Firm Firm { get; set; } = null!;

        /// <summary>
        /// Collection with Operation Entity
        /// </summary>
        public ICollection<Operation> Operations { get; set; }
            = new List<Operation>();
    }
}
