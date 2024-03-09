namespace MarketVault.Models.Measure
{
    /// <summary>
    /// Measure view model
    /// </summary>
    public class MeasureViewModel
    {
        /// <summary>
        /// Measure id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Measure name
        /// </summary>
        public string Value { get; set; } = string.Empty;
    }
}
