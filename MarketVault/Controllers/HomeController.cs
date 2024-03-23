namespace MarketVault.Controllers
{
    using MarketVault.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;

    /// <summary>
    /// Home Controller - default controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<HomeController> _logger;

        /// <summary>
        /// Role manager
        /// </summary>
        private RoleManager<IdentityRole> _roleManager;

        /// <summary>
        /// User manager
        /// </summary>
        private UserManager<IdentityUser> _userManager;

        /// <summary>
        /// Constructor injecting logger
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="userManager">User Manager</param>
        /// <param name="roleManager">Role Manager</param>
        public HomeController(ILogger<HomeController> logger,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        /// <summary>
        /// Default action which leads to home page
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            // Create roles
            string[] roleNames = { "Admin", "User", "Worker" };
            foreach (var roleName in roleNames)
            {
                var roleExists = await _roleManager.RoleExistsAsync(roleName);
                if (!roleExists)
                {
                    var role = new IdentityRole(roleName);
                    await _roleManager.CreateAsync(role);
                    await _roleManager.UpdateAsync(role);
                }
            }

            // Create admin user
            var adminUser = await _userManager.FindByEmailAsync("admin@example.com");
            if (adminUser == null)
            {
                var user = new IdentityUser
                {
                    UserName = "admin@example.com",
                    Email = "admin@example.com"
                };
                var result = await _userManager.CreateAsync(user, "admin");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                }
                await _userManager.UpdateAsync(user);
            }

            // Create worker user
            var workerUser = await _userManager.FindByEmailAsync("worker@example.com");
            if (workerUser == null)
            {
                var user = new IdentityUser
                {
                    UserName = "worker@example.com",
                    Email = "worker@example.com"
                };
                var result = await _userManager.CreateAsync(user, "worker");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Worker");
                }
                await _userManager.UpdateAsync(user);
            }

            // Create user
            var userUser = await _userManager.FindByEmailAsync("user@example.com");
            if (userUser == null)
            {
                var user = new IdentityUser
                {
                    UserName = "user@example.com",
                    Email = "user@example.com"
                };
                var result = await _userManager.CreateAsync(user, "user");
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "User");
                }
                await _userManager.UpdateAsync(user);
            }

            return View();
        }

        public IActionResult Error(int statusCode)
        {
            if (statusCode == 404)
            {
                return View("Error404");
            }
            else if (statusCode == 400)
            {
                return View("Error400");
            }

            return View();
        }
    }
}
