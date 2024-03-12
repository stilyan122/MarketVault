namespace MarketVault.Models.Bank
{
    /// <summary>
    /// Bank View Model
    /// </summary>
    public class BankViewModel
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
        /// Bank address id
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Bank address town name
        /// </summary>
        public string TownName { get; set; } = string.Empty;

        /// <summary>
        /// Bank address street name
        /// </summary>
        public string StreetName { get; set; } = string.Empty;

        /// <summary>
        /// Bank address street number
        /// </summary>
        public string StreetNumber { get; set; } = string.Empty;
    }
}
