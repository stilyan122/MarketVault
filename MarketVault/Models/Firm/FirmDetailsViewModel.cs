namespace MarketVault.Models.Firm
{
    /// <summary>
    /// Detailed firm view model
    /// </summary>
    public class FirmDetailsViewModel : FirmViewModel
    {
        /// <summary>
        /// Firm address
        /// </summary>
        public string Address { get; set; } = string.Empty;
    }
}
