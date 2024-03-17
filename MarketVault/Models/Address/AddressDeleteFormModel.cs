﻿namespace MarketVault.Models.Address
{
    /// <summary>
    /// Address delete form model
    /// </summary>
    public class AddressDeleteFormModel
    {
        /// <summary>
        /// Address id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Address town name
        /// </summary>
        public string TownName { get; set; } = string.Empty;

        /// <summary>
        /// Address street name
        /// </summary>
        public string StreetName { get; set; } = string.Empty;

        /// <summary>
        /// Address street number
        /// </summary>
        public string StreetNumber { get; set; } = string.Empty;
    }
}
