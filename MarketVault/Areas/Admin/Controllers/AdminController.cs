namespace MarketVault.Areas.Admin.Controllers
{
    using MarketVault.Areas.Admin.AdminModels;
    using MarketVault.Core;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Admin controller class
    /// </summary>
    public class AdminController : AdminBaseController
    {
        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<AdminController> logger;

        /// <summary>
        /// User service
        /// </summary>
        private readonly IUserService userService;

        /// <summary>
        /// User manager
        /// </summary>
        private readonly UserManager<ApplicationUser> roleManager;

        /// <summary>
        /// Default constructor, injection of logger, service and manager (DI)
        /// </summary>
        /// <param name="logger">Logger</param>
        /// <param name="userService">IUserService</param>
        /// <param name="roleManager">UserManager</param>
        public AdminController(
            ILogger<AdminController> logger,
            IUserService userService,
            UserManager<ApplicationUser> roleManager)
        {
            this.logger = logger;
            this.userService = userService;
            this.roleManager = roleManager;
        }

        /// <summary>
        /// Index method
        /// </summary>
        /// <returns>IActionResult</returns>
        public IActionResult Index()
        {
            logger.LogInformation("Admin/Index method invoked.");
            return View();
        }

        /// <summary>
        /// Get all users method (Asynchronous)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> GetAllUsers(int pages = 1)
        {
            var allUsers = await this.userService.GetAllUsersAsync();

            var models = new List<UserViewModel>();

            foreach (ApplicationUser user in allUsers)
            {
                var roles = await roleManager.GetRolesAsync(user);
                var role = roles.First();

                var model = new UserViewModel()
                {
                    Email = user.Email,
                    FirstName = user.FirstName,
                    Id = user.Id,
                    LastName = user.LastName,
                    Role = role
                };

                models.Add(model);
            }

            const int pageSize = 5;

            if (pages < 1)
            {
                pages = 1;
            }

            int recsCount = models.Count;

            var pager = new Pager(recsCount, pages, pageSize)
            {
                Action = "GetAllUsers",
                Controller = "Admin"
            };

            int recsSkip = (pages - 1) * pageSize;

            var data = models
                .Skip(recsSkip)
                .Take(pager.PageSize)
                .ToList();

            this.ViewBag.Pager = pager;

            return View(data);
        }
    }
}
