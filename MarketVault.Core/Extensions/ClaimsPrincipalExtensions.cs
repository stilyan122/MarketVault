namespace MarketVault.Core.Extensions
{
    using System.Security.Claims;

    /// <summary>
    /// Extension class for ClaimsPrincipal
    /// </summary>
    public static class ClaimsPrincipalExtensions
    {
        /// <summary>
        /// Extension method for getting user id
        /// </summary>
        /// <param name="user">ClaimsPrincipal</param>
        /// <returns>(string) => the id</returns>
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
