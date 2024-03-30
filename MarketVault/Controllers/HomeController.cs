namespace MarketVault.Controllers
{
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Services.Interfaces;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Home Controller - default controller
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<HomeController> logger;

        /// <summary>
        /// User service
        /// </summary>
        private readonly IUserService userService;

        /// <summary>
        /// Constructor injecting logger and service
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="service">IUserService</param>
        public HomeController(
            ILogger<HomeController> logger,
            IUserService service)
        {
            this.logger = logger;
            this.userService = service;
        }

        /// <summary>
        /// Default action which leads to home page
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            try
            {
                // Create roles
                string[] roleNames = { "Admin", "User", "Worker" };
                foreach (var roleName in roleNames)
                {
                    var roleExists = await userService.RoleExistsAsync(roleName);
                    if (!roleExists)
                    {
                        var role = new IdentityRole(roleName);
                        await userService.CreateRoleAsync(role);
                        await userService.UpdateRoleAsync(role);
                    }
                }

                // Create admin user
                var adminUser = await userService.FindUserByEmailAsync("admin@example.com");
                if (adminUser == null)
                {
                    var user = new IdentityUser
                    {
                        UserName = "admin@example.com",
                        Email = "admin@example.com",
                        Id = "1db5c825-2f5e-4646-98dc-52bf094f9bf6"
                    };
                    var result = await userService.CreateUserAsync(user, "admin");
                    if (result.Succeeded)
                    {
                        await userService.AddUserToRoleAsync(user, "Admin");
                    }
                    await userService.UpdateUserAsync(user);
                }

                // Create worker user
                var workerUser = await userService.FindUserByEmailAsync("worker@example.com");
                if (workerUser == null)
                {
                    var user = new IdentityUser
                    {
                        UserName = "worker@example.com",
                        Email = "worker@example.com",
                        Id = "7bc64720-42fc-4617-bdfa-a7eb00e7e9de"
                    };
                    var result = await userService.CreateUserAsync(user, "worker");
                    if (result.Succeeded)
                    {
                        await userService.AddUserToRoleAsync(user, "Worker");
                    }
                    await userService.UpdateUserAsync(user);
                }

                // Create user
                var userUser = await userService.FindUserByEmailAsync("user@example.com");
                if (userUser == null)
                {
                    var user = new IdentityUser
                    {
                        UserName = "user@example.com",
                        Email = "user@example.com",
                        Id = "6041532e-28d8-48d3-ba2f-72a04f7abd42"
                    };
                    var result = await userService.CreateUserAsync(user, "user");
                    if (result.Succeeded)
                    {
                        await userService.AddUserToRoleAsync(user, "User");
                    }
                    await userService.UpdateUserAsync(user);
                }
            }
            catch (UserNotFoundException exc)
            {
                logger.LogError(exc, "Home/Index");
            }

            return View();
        }

        /// <summary>
        /// Error
        /// </summary>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public IActionResult Error(int statusCode = 0)
        {
            if (statusCode == 404)
            {
                return View("Error404");
            }
            else if (statusCode == 400)
            {
                return View("Error400");
            }
            else if(statusCode == 403)
            {
                return View("Error403");
            }
            else
            {
                return View("ErrorUnexpected");
            }
        }
    }
}
