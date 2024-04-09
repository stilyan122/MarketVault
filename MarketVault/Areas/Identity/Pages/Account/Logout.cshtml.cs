#nullable disable
namespace MarketVault.Areas.Identity.Pages.Account
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    /// <summary>
    /// Log out model
    /// </summary>
    public class LogoutModel : PageModel
    {
        /// <summary>
        /// Sign in manager
        /// </summary>
        private readonly SignInManager<ApplicationUser> _signInManager;

        /// <summary>
        /// Default constructor, injection of manager
        /// </summary>
        /// <param name="signInManager">Sign in manager</param>
        public LogoutModel(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        /// <summary>
        /// On post method (Asynchronous)
        /// </summary>
        /// <param name="returnUrl">Return URL</param>
        /// <returns></returns>
        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            { 
                return RedirectToPage();
            }
        }
    }
}
