namespace MarketVault.Models.Firm
{
    /// <summary>
    /// Firm View Model
    /// </summary>
    public class FirmViewModel
    {
        /// <summary>
        /// Firm id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Firm name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Firm phone number
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Firm email
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Firm responsible person name
        /// </summary>
        public string ResponsiblePersonName { get; set; } = string.Empty;

        /// <summary>
        /// Firm address id
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Firm address town name
        /// </summary>
        public string TownName { get; set; } = string.Empty;

        /// <summary>
        /// Firm address street name
        /// </summary>
        public string StreetName { get; set; } = string.Empty;

        /// <summary>
        /// Firm address street number
        /// </summary>
        public string StreetNumber { get; set; } = string.Empty;
    }
}
