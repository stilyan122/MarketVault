namespace MarketVault.Models.Operation
{
    using MarketVault.Models.CounterParty;
    using MarketVault.Models.DocumentType;
    using MarketVault.Models.Product;

    /// <summary>
    /// Operation form model
    /// </summary>
    public class OperationFormModel
    {
        /// <summary>
        /// Model document type id
        /// </summary>
        public int DocumentTypeId { get; set; }

        /// <summary>
        /// Model counter party id
        /// </summary>
        public int CounterPartyId { get; set; }

        /// <summary>
        /// Model collection of products
        /// </summary>
        public IEnumerable<ProductOperationModel> Products { get; set; }
            = new List<ProductOperationModel>();

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
