namespace MarketVault.Core.Models
{
    /// <summary>
    /// Service model used for document type entity
    /// </summary>
    public class DocumentTypeServiceModel
    {
        /// <summary>
        /// Service model id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Service model name
        /// </summary>
        public string Name { get; set; } = string.Empty;
    }
}
