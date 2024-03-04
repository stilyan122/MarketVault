namespace MarketVault.Models.CounterParty
{
    /// <summary>
    /// Detailed counter party view model
    /// </summary>
    public class CounterPartyDetailsViewModel : CounterPartyViewModel
    {
        /// <summary>
        /// Counter party town name
        /// </summary>
        public string TownName { get; set; } = string.Empty;

        /// <summary>
        /// Counter party street name
        /// </summary>
        public string StreetName { get; set; } = string.Empty;

        /// <summary>
        /// Counter party street number
        /// </summary>
        public string StreetNumber { get; set; } = string.Empty;

        /// <summary>
        /// Counter party firm phone number
        /// </summary>
        public string FirmPhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Counter party firm email
        /// </summary>
        public string FirmEmail { get; set; } = string.Empty;

        /// <summary>
        /// Counter party firm responsible person name
        /// </summary>
        public string FirmResponsiblePersonName { get; set; } = string.Empty;
    }
}
