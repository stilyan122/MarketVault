namespace MarketVault.Models.CounterParty
{
    /// <summary>
    /// Detailed counter party view model
    /// </summary>
    public class CounterPartyDetailsViewModel : CounterPartyViewModel
    {
        /// <summary>
        /// Counter party bank address
        /// </summary>
        public string BankAddress { get; set; } = string.Empty;

        /// <summary>
        /// Counter party firm address
        /// </summary>
        public string FirmAddress { get; set; } = string.Empty;

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
