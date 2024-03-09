namespace MarketVault.Core.Models
{
    /// <summary>
    /// Service model used for measure entity
    /// </summary>
    public class MeasureServiceModel
    {
        /// <summary>
        /// Service model id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Service model value
        /// </summary>
        public string Value { get; set; } = string.Empty;
    }
}
