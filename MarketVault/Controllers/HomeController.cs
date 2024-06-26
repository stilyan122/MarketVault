﻿namespace MarketVault.Controllers
{
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Extensions;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using static MarketVault.Infrastructure.Constants.DataConstants
        .RoleConstants;

    /// <summary>
    /// Home Controller - default controller
    /// </summary>
    public class HomeController : BaseController
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
        /// <param name="isAdminForPublicInterface">Bool flag to keep if the admin comes from a admin area</param>
        /// <returns>Task<IActionResult></returns>
        [AllowAnonymous]
        public async Task<IActionResult> Index(bool isAdminForPublicInterface = false)
        {
            logger.LogInformation("Home/Index action has been invoked.");

            try
            {
                // Create roles
                string[] roleNames = { AdminRole, "User", "Worker" };
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
                    var user = new ApplicationUser
                    {
                        UserName = "admin@example.com",
                        Email = "admin@example.com",
                        Id = "1db5c825-2f5e-4646-98dc-52bf094f9bf6",
                        FirstName = AdminRole,
                        LastName = AdminRole
                    };
                    var result = await userService.CreateUserAsync(user, "admin");
                    if (result.Succeeded)
                    {
                        await userService.AddUserToRoleAsync(user, AdminRole);
                    }
                    await userService.UpdateUserAsync(user);
                }

                // Create worker user
                var workerUser = await userService.FindUserByEmailAsync("worker@example.com");
                if (workerUser == null)
                {
                    var user = new ApplicationUser
                    {
                        UserName = "worker@example.com",
                        Email = "worker@example.com",
                        Id = "7bc64720-42fc-4617-bdfa-a7eb00e7e9de",
                        FirstName = "Worker",
                        LastName = "Worker"
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
                    var user = new ApplicationUser
                    {
                        UserName = "user@example.com",
                        Email = "user@example.com",
                        Id = "6041532e-28d8-48d3-ba2f-72a04f7abd42",
                        FirstName = "User",
                        LastName = "User"
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

            if ((this.User?.Identity?.IsAuthenticated ?? false) && 
                isAdminForPublicInterface == false)
            {
                if (await this.userService
                .IsInRoleAsync(new string[] { AdminRole },
                User.Id()))
                {
                    return RedirectToAction("Index", AdminRole, new { area = AdminRole });
                }
            }

            return View();
        }

        /// <summary>
        /// Method for FAQ page
        /// </summary>
        /// <returns>IActionResult</returns>
        [AllowAnonymous]
        public IActionResult FAQ()
        {
            logger.LogInformation("Home/FAQ action has been invoked.");
            return View();
        }

        /// <summary>
        /// Error
        /// </summary>
        /// <param name="statusCode"></param>
        /// <returns>IActionResult</returns>
        public IActionResult Error(int statusCode = 0)
        {
            logger.LogError($"An error has been thrown. Status code provided: {statusCode}", statusCode);

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
