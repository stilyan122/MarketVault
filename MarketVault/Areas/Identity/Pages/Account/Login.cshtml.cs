#nullable disable
namespace MarketVault.Areas.Identity.Pages.Account
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants.DataConstants.RoleConstants;

    /// <summary>
    /// Log in model
    /// </summary>
    public class LoginModel : PageModel
    {
        /// <summary>
        /// Sign in manager
        /// </summary>
        private readonly SignInManager<ApplicationUser> _signInManager;

        /// <summary>
        /// User manager
        /// </summary>
        private readonly UserManager<ApplicationUser> _userManager;

        /// <summary>
        /// Default constructor, injection of managers (DI)
        /// </summary>
        /// <param name="signInManager">Sign in manager</param>
        /// <param name="userManager">User manager</param>
        public LoginModel(SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        /// <summary>
        /// Input property
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }
        
        /// <summary>
        /// Return URL property
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Error message property
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Input model class
        /// </summary>
        public class InputModel
        {
            /// <summary>
            /// Input email
            /// </summary>
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            /// <summary>
            /// Input password
            /// </summary>
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            /// <summary>
            /// Input first name
            /// </summary>
            [Required]
            [Display(Name = "First Name")]
            public string FirstName { get; set; }

            /// <summary>
            /// Input last name
            /// </summary>
            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }
        }

        /// <summary>
        /// On get async method (Void)
        /// </summary>
        /// <param name="returnUrl">Return URL</param>
        public void OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            ReturnUrl = returnUrl;
        }

        /// <summary>
        /// On post async method (Asynchronous)
        /// </summary>
        /// <param name="returnUrl">Return URL</param>
        /// <returns></returns>
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(
                    Input.Email, 
                    Input.Password,
                    true, 
                    lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(Input.Email);
                    if (await this._userManager.IsInRoleAsync(user, AdminRole))
                    {
                        return RedirectToAction("Index", "Admin", new {area = AdminRole});
                    }

                    if (returnUrl.Contains("Home/Error"))
                    {
                        returnUrl = "/Home/Index";
                    }

                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            return Page();
        }
    }
}
