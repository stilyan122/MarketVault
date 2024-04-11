namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// UserService
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// User manager
        /// </summary>
        private readonly UserManager<ApplicationUser> userManager = null!;

        /// <summary>
        /// Role manager
        /// </summary>
        private readonly RoleManager<IdentityRole> roleManager = null!;

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<UserService> logger = null!;

        /// <summary>
        /// Constructor, injecting managers and logger (DI)
        /// </summary>
        /// <param name="userManager">UserManager</param>
        /// <param name="roleManager">RoleManager</param>
        /// <param name="logger">Logger</param>
        public UserService(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<UserService> logger)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.logger = logger;
        }

        /// <summary>
        /// Method to create a given role (Asynchronous)
        /// </summary>
        /// <param name="role">IdentityRole</param>
        /// <returns>Task<IdentityResult> </returns>
        public async Task<IdentityResult> CreateRoleAsync(IdentityRole role)
        {
            logger.LogInformation("Create role async method in user service invoked.");

            return await this.roleManager.CreateAsync(role);
        }

        /// <summary>
        /// Get users count (Asynchronous)
        /// </summary>
        /// <returns>Task<int></returns>
        public async Task<int> GetUsersCountAsync()
        {
            return await this.userManager.Users.CountAsync();
        }

        /// <summary>
        /// Method to get all users
        /// </summary>
        /// <returns>Task<IEnumerable<ApplicationUser>></returns>
        public async Task<IEnumerable<ApplicationUser>> GetAllUsersAsync()
        {
            var users = await this.userManager
                .Users
                .Where(u => !String.IsNullOrEmpty(u.PasswordHash))
                .ToListAsync();

            return users;
        }

        /// <summary>
        /// Method to check if a given user by id is in role(s) (Asynchronous)
        /// </summary>
        /// <param name="roles">The roles to check</param>
        /// <param name="userId">User id to check</param>
        /// <returns>Task<bool></returns>
        public async Task<bool> IsInRoleAsync(string[] roles, string userId)
        {
            logger.LogInformation("Is in role async method in user service invoked.");

            logger.LogWarning("Potential user not found exceptions to be thrown.");

            if (userId == null)
            {
                throw new UserNotFoundException("No such user found!");
            }

            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                throw new UserNotFoundException("No such user found!");
            }

            bool result = false;

            foreach (string role in roles)
            {
                if (await this.userManager.IsInRoleAsync(user, role))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        /// <summary>
        /// Method to check if a role exists (Asynchronous)
        /// </summary>
        /// <param name="role">Role name</param>
        /// <returns>Task<bool></returns>
        public Task<bool> RoleExistsAsync(string role)
        {
            logger.LogInformation("Role exists async method in user service invoked.");

            return this.roleManager.RoleExistsAsync(role);
        }

        /// <summary>
        /// Method to update a given role (Asynchronous)
        /// </summary>
        /// <param name="role">IdentityRole</param>
        /// <returns>Task<IdentityResult> </returns>
        public async Task<IdentityResult> UpdateRoleAsync(IdentityRole role)
        {
            logger.LogInformation("Update role async method in user service invoked.");

            return await this.roleManager.UpdateAsync(role);
        }

        /// <summary>
        /// Method to find and return a user by email (Asynchronous)
        /// </summary>
        /// <param name="email">Email to search for</param>
        /// <returns>Task<ApplicationUser></returns>
        public async Task<ApplicationUser> FindUserByEmailAsync(string email)
        {
            logger.LogInformation("Find user by email async method in user service invoked.");

            return await this.userManager.FindByEmailAsync(email);
        }

        /// <summary>
        /// Method to find and return a user by id (Asynchronous)
        /// </summary>
        /// <param name="id">Id to search for</param>
        /// <returns>Task<ApplicationUser></returns>
        public async Task<ApplicationUser> FindUserByIdAsync(string id)
        {
            return await this.userManager.FindByIdAsync(id);
        }

        /// <summary>
        /// Method to create a given user (Asynchronous)
        /// </summary>
        /// <param name="user">ApplicationUser</param>
        /// <param name="password">User password</param>
        /// <returns>Task<IdentityResult></returns>
        public async Task<IdentityResult> CreateUserAsync(ApplicationUser user, 
            string password)
        {
            logger.LogInformation("Create user async method in user service invoked.");

            var result = await this.userManager.CreateAsync(user, password);

            return result;
        }

        /// <summary>
        /// Method to update a given user (Asynchronous)
        /// </summary>
        /// <param name="user">ApplicationUser</param>
        /// <returns>Task<IdentityResult> </returns>
        public async Task<IdentityResult> UpdateUserAsync(ApplicationUser user)
        {
            logger.LogInformation("Update user async method in user service invoked.");

            return await this.userManager.UpdateAsync(user);
        }

        /// <summary>
        /// Method to delete a given user (Asynchronous)
        /// </summary>
        /// <param name="user">ApplicationUser</param>
        /// <returns>Task<IdentityResult> </returns>
        public async Task<IdentityResult> DeleteUserAsync(ApplicationUser user)
        {
            logger.LogInformation("Delete user async method in user service invoked.");

            return await this.userManager.DeleteAsync(user);
        }

        /// <summary>
        /// Method to add a user to a role (Asynchronous)
        /// </summary>
        /// <param name="user">ApplicationUser</param>
        /// <param name="role">Role</param>
        /// <returns>Task<IdentityResult> </returns>
        public async Task<IdentityResult> AddUserToRoleAsync(ApplicationUser user, string role)
        {
            logger.LogInformation("Add user to role async method in user service invoked.");

            return await this.userManager.AddToRoleAsync(user, role);
        }

        /// <summary>
        /// Method to get user full name (Asynchronous)
        /// </summary>
        /// <param name="userId">User id</param>
        /// <returns>Task<string></returns>
        public async Task<string> GetUserFullNameAsync(string userId)
        {
            var user = await this.userManager.FindByIdAsync(userId);
            
            if (String.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName))
            {
                return "Na";
            }

            var roles = await this.userManager.GetRolesAsync(user);
            var role = roles.First();

            return user.FirstName + " " + user.LastName + $" ({role})";
        }
    }
}
