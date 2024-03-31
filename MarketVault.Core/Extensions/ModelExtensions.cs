namespace MarketVault.Core.Extensions
{
    using MarketVault.Core.Contracts;
    using System.Web;

    /// <summary>
    /// Model extensions class - static
    /// </summary>
    public static class ModelExtensions
    {
        /// <summary>
        /// Method for getting details from a model
        /// </summary>
        /// <param name="model">IUrlDetailModel</param>
        /// <returns></returns>
        public static string GetDetails(this IUrlDetailModel model)
        {
            return HttpUtility.UrlEncode(model.Information);
        }
    }
}
