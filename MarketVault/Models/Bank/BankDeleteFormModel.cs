namespace MarketVault.Models.Bank
{
    /// <summary>
    /// Bank delete form model
    /// </summary>
    public class BankDeleteFormModel
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
