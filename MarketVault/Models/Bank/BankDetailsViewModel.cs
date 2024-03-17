namespace MarketVault.Models.Bank
{
    /// <summary>
    /// Detailed bank view model
    /// </summary>
    public class BankDetailsViewModel
    {
        /// <summary>
        /// Bank id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Bank name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Bank address
        /// </summary>
        public string Address { get; set; } = string.Empty;
    }
}
