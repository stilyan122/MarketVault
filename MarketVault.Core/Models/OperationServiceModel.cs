namespace MarketVault.Core.Models
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity;

    /// <summary>
    /// Service model used for Operation entity
    /// </summary>
    public class OperationServiceModel
    {
        /// <summary>
        /// Service model id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Service model document type id
        /// </summary>
        public int DocumentTypeId { get; set; }

        /// <summary>
        /// Service model document type
        /// </summary>
        public DocumentType DocumentType { get; set; } = null!;

        /// <summary>
        /// Service model counter party id
        /// </summary>
        public int CounterPartyId { get; set; }

        /// <summary>
        /// Service model counter party
        /// </summary>
        public CounterParty CounterParty { get; set; } = null!;

        /// <summary>
        /// Service model total sale price without VAT
        /// </summary>
        public decimal TotalSalePriceWithoutVAT { get; set; }

        /// <summary>
        /// Service model total sale price with VAT
        /// </summary>
        public decimal TotalSalePriceWithVAT { get; set; }

        /// <summary>
        /// Service model total purchase price without VAT
        /// </summary>
        public decimal TotalPurchasePriceWithoutVAT { get; set; }

        /// <summary>
        /// Service model total purchase price with VAT
        /// </summary>
        public decimal TotalPurchasePriceWithVAT { get; set; }

        /// <summary>
        /// Service model date time when made
        /// </summary>
        public DateTime DateMade { get; set; } = DateTime.Now;

        /// <summary>
        /// Service model creator id
        /// </summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// Service model creator - user
        /// </summary>
        public ApplicationUser User { get; set; } = null!;
    }
}
