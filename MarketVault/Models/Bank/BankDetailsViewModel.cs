namespace MarketVault.Models.Bank
{
    /// <summary>
    /// Detailed bank view model
    /// </summary>
    public class BankDetailsViewModel : BankViewModel
    {
        /// <summary>
        /// Bank address
        /// </summary>
        public string Address { get; set; } = string.Empty;
    }
}
