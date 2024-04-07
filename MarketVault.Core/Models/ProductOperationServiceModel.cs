using System.ComponentModel.DataAnnotations;

namespace MarketVault.Core.Models
{
    /// <summary>
    /// Service model used for ProductMeasure entity
    /// </summary>
    public class ProductOperationServiceModel
    {
        /// <summary>
        /// Service model product id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Service model operation id
        /// </summary>
        public int OperationId { get; set; }

        /// <summary>
        /// Model id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Model document type id
        /// </summary>
        [Required(ErrorMessage = "Document Type is required!")]
        public int? DocumentTypeId { get; set; }

        /// <summary>
        /// Model counter party id
        /// </summary>
        [Required(ErrorMessage = "Counter Party is required!")]
        public int? CounterPartyId { get; set; }

        /// <summary>
        /// Model collection of products
        /// </summary>
        public List<ProductForOperationServiceModel> Products { get; set; }
            = new List<ProductForOperationServiceModel>();

        /// <summary>
        /// Model collection of JSON products
        /// </summary>
        public List<string> ProductsJson { get; set; }
            = new List<string>();
    }
}
