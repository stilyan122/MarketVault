// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System.ComponentModel.DataAnnotations;
namespace MarketVault.Areas.Identity.Pages.Account
{
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.Threading.Tasks;
    using static MarketVault.Infrastructure.Constants.DataConstants.ExceptionMessagesConstants;
    using static MarketVault.Infrastructure.Constants.DataConstants.UserConstants;

    /// <summary>
    /// Register page model
    /// </summary>
    public class RegisterModel : PageModel
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
        /// Default constructor, injection of managers
        /// </summary>
        /// <param name="userManager">User manager</param>
        /// <param name="signInManager">Sign in manager</param>
        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        /// Input model property
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        /// Return URL property
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Input model class
        /// </summary>
        public class InputModel
        { 
            /// <summary>
            /// Input model email
            /// </summary>
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            /// <summary>
            /// Input model password
            /// </summary>
            [Required]
            [StringLength(PasswordMaxLength, 
                ErrorMessage = 
                PasswordLengthExceptionMessage, 
                MinimumLength = PasswordMinLength)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            /// <summary>
            /// Input model confirm password
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password",
                ErrorMessage = ConfirmPasswordLengthExceptionMessage)]
            public string ConfirmPassword { get; set; }

            /// <summary>
            /// Input model first name
            /// </summary>
            [Required(ErrorMessage = FirstNameRequiredExceptionMessage)]
            [DataType(DataType.Text)]
            [Display(Name = "First name")]
            [StringLength(FirstNameMaxLength,
                MinimumLength = FirstNameMinLength,
                ErrorMessage = FirstNameLengthExceptionMessage)]
            public string FirstName { get; set; }

            /// <summary>
            /// Input model last name
            /// </summary>
            [Required(ErrorMessage = LastNameRequiredExceptionMessage)]
            [DataType(DataType.Text)]
            [Display(Name = "Last name")]
            [StringLength(LastNameMaxLength,
                MinimumLength = LastNameMinLength,
                ErrorMessage = LastNameLengthExceptionMessage)]
            public string LastName { get; set; }
        }

        /// <summary>
        /// On get async method (Void)
        /// </summary>
        /// <param name="returnUrl"></param>
        public void OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        /// <summary>
        /// On post async method (Asynchronous)
        /// </summary>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = (ApplicationUser) Activator.CreateInstance(typeof(ApplicationUser));
                user.UserName = Input.Email;
                user.Email = Input.Email;
                user.FirstName = Input.FirstName;
                user.LastName = Input.LastName;
                user.Id = Guid.NewGuid().ToString();

                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {     
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return Page();
        }
    }
}
