namespace MarketVault.Infrastructure.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Operation Entity
    /// </summary>
    [Comment("Operation Entity Class")]
    public class Operation
    {
        /// <summary>
        /// Operation Identificator
        /// </summary>
        [Comment("Operation Identificator")]
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// DocumentTypeId - foreign key
        /// </summary>
        [Required]
        [ForeignKey(nameof(DocumentType))]
        [Comment("DocumentTypeId - FK")]
        public int DocumentTypeId { get; set; }

        /// <summary>
        /// DocumentType Entity
        /// </summary>
        public DocumentType DocumentType { get; set; } = null!;

        /// <summary>
        /// CounterPartyId - foreign key
        /// </summary>
        [Required]
        [ForeignKey(nameof(CounterParty))]
        [Comment("CounterPartyId - FK")]
        public int CounterPartyId { get; set; }

        /// <summary>
        /// CounterParty Entity
        /// </summary>
        public CounterParty CounterParty { get; set; } = null!;

        /// <summary>
        /// TotalSalePriceWithoutVAT
        /// </summary>
        [Comment("TotalSalePriceWithoutVAT")]
        public decimal TotalSalePriceWithoutVAT { get; set; }

        /// <summary>
        /// TotalSalePriceWithVAT
        /// </summary>
        [Comment("TotalSalePriceWithVAT")]
        public decimal TotalSalePriceWithVAT { get; set; }

        /// <summary>
        /// TotalPurchasePriceWithoutVAT
        /// </summary>
        [Comment("TotalPurchasePriceWithoutVAT")]
        public decimal TotalPurchasePriceWithoutVAT { get; set; }

        /// <summary>
        /// TotalPurchasePriceWithVAT
        /// </summary>
        [Comment("TotalPurchasePriceWithVAT")]
        public decimal TotalPurchasePriceWithVAT { get; set; }

        /// <summary>
        /// DateTime Date when made
        /// </summary>
        [Comment("DateTime when made")]
        public DateTime DateMade { get; set; } = DateTime.Now;

        /// <summary>
        /// User id - person who did the operation
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// User entity
        /// </summary>
        public IdentityUser User { get; set; } = null!;

        /// <summary>
        /// Collection with entities from the mapping table - ProductsOperations
        /// </summary>
        public IEnumerable<ProductOperation> ProductsOperations { get; set; }
            = new List<ProductOperation>();
    }
}
