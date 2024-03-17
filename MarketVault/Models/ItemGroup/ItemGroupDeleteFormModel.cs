namespace MarketVault.Models.ItemGroup
{
    /// <summary>
    /// Item group delete form model
    /// </summary>
    public class ItemGroupDeleteFormModel
    {
        /// <summary>
        /// Item group id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Item group name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Item group products count
        /// </summary>
        public int ProductsCount { get; set; }
    }
}
