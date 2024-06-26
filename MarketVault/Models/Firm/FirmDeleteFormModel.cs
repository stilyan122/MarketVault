﻿namespace MarketVault.Models.Firm
{
    using MarketVault.Core.Contracts;

    /// <summary>
    /// Firm delete form model
    /// </summary>
    public class FirmDeleteFormModel : IUrlDetailModel
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
        /// Firm email
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Firm phone number
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Firm responsible person name
        /// </summary>
        public string ResponsiblePersonName { get; set; } = string.Empty;

        /// <summary>
        /// Firm address
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Model Information - for URL
        /// </summary>
        public string Information { get; set; } = string.Empty;
    }
}
