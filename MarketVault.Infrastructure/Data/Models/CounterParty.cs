namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

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

        /// <summary>
        /// Flag for activity 
        /// </summary>
        [Comment("Flag for activity")]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// CounterParty VAT Number
        /// </summary>
        [Required]
        public int VATNumber { get; set; }

        [Required]
        /// <summary>
        /// CounterParty ValueAddedTaxLaw Id
        /// </summary>
        public int ValueAddedTaxLawId { get; set; }

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
        [ForeignKey(nameof(Bank))]
        [Required]
        public int FirmId { get; set; }

        /// <summary>
        /// Firm Entity
        /// </summary>
        public Firm Firm { get; set; } = null!;
    }
}
