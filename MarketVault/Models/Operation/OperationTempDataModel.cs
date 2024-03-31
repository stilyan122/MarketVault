namespace MarketVault.Models.Operation
{
    using MarketVault.Models.Product;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Operation model for TempData
    /// </summary>
    public class OperationTempDataModel
    {
        /// <summary>
        /// Model document type id
        /// </summary>
        [Required]
        public int DocumentTypeId { get; set; }

        /// <summary>
        /// Model counter party id
        /// </summary>
        [Required]
        public int CounterPartyId { get; set; }

        /// <summary>
        /// Model collection of products
        /// </summary>
        public List<ProductOperationModel> Products { get; set; }
            = new List<ProductOperationModel>();
    }
}
