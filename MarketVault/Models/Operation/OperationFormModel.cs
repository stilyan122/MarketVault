namespace MarketVault.Models.Operation
{
    using MarketVault.Models.CounterParty;
    using MarketVault.Models.DocumentType;
    using MarketVault.Models.Product;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Operation form model
    /// </summary>
    public class OperationFormModel
    {
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
        public List<ProductOperationModel> Products { get; set; }
            = new List<ProductOperationModel>();

        /// <summary>
        /// Model collection of JSON products
        /// </summary>
        public List<string> ProductsJson { get; set; }
            = new List<string>();

        /// <summary>
        /// Model collection of counter parties
        /// </summary>
        public IEnumerable<CounterPartyViewModel> CounterParties { get; set; }
            = new List<CounterPartyViewModel>();

        /// <summary>
        /// Model collection of document types
        /// </summary>
        public IEnumerable<DocumentTypeViewModel> DocumentTypes { get; set; }
            = new List<DocumentTypeViewModel>();
    }
}
