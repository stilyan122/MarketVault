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
    using Microsoft.Extensions.Logging;
    using System.Threading;
    using System.Threading.Tasks;
    using static MarketVault.Infrastructure.Constants.DataConstants.ExceptionMessagesConstants;
    using static MarketVault.Infrastructure.Constants.DataConstants.UserConstants;

    /// <summary>
    /// Register page model
    /// </summary>
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        { 
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [Required(ErrorMessage = FirstNameRequiredExceptionMessage)]
            [DataType(DataType.Text)]
            [Display(Name = "First name")]
            [StringLength(FirstNameMaxLength,
                MinimumLength = FirstNameMinLength,
                ErrorMessage = FirstNameLengthExceptionMessage)]
            public string FirstName { get; set; }

            [Required(ErrorMessage = LastNameRequiredExceptionMessage)]
            [DataType(DataType.Text)]
            [Display(Name = "Last name")]
            [StringLength(LastNameMaxLength,
                MinimumLength = LastNameMinLength,
                ErrorMessage = LastNameLengthExceptionMessage)]
            public string LastName { get; set; }
        }


        public void OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

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
