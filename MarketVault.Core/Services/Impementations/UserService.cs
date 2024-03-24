namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Exceptions;
    using MarketVault.Core.Services.Interfaces;
    using Microsoft.AspNetCore.Identity;

    /// <summary>
    /// UserService
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// User manager
        /// </summary>
        private readonly UserManager<IdentityUser> userManager;

        /// <summary>
        /// Role manager
        /// </summary>
        private readonly RoleManager<IdentityRole> roleManager;

        /// <summary>
        /// Constructor, injecting managers (DI)
        /// </summary>
        /// <param name="userManager">UserManager</param>
        /// <param name="roleManager">RoleManager</param>
        public UserService(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }

        /// <summary>
        /// Method to create a given role (Asynchronous)
        /// </summary>
        /// <param name="role">IdentityRole</param>
        /// <returns>(void)</returns>
        public async Task CreateRoleAsync(IdentityRole role)
        {
            await this.roleManager.CreateAsync(role);
        }

        /// <summary>
        /// Method to check if a given user by id is in role(s) (Asynchronous)
        /// </summary>
        /// <param name="roles">The roles to check</param>
        /// <param name="userId">User id to check</param>
        /// <returns>Task<bool></returns>
        public async Task<bool> IsInRoleAsync(string[] roles, string userId)
        {
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
            return this.roleManager.RoleExistsAsync(role);
        }

        /// <summary>
        /// Method to update a given role (Asynchronous)
        /// </summary>
        /// <param name="role">IdentityRole</param>
        /// <returns>(void)</returns>
        public async Task UpdateRoleAsync(IdentityRole role)
        {
            await this.roleManager.UpdateAsync(role);
        }

        /// <summary>
        /// Method to find and return a user by email (Asynchronous)
        /// </summary>
        /// <param name="email">Email to search for</param>
        /// <returns>Task<IdentityUser></returns>
        public async Task<IdentityUser> FindUserByEmailAsync(string email)
        {
            return await this.userManager.FindByEmailAsync(email);
        }

        /// <summary>
        /// Method to create a given user (Asynchronous)
        /// </summary>
        /// <param name="user">IdentityUser</param>
        /// <param name="password">User password</param>
        /// <returns>Task<IdentityResult></returns>
        public async Task<IdentityResult> CreateUserAsync(IdentityUser user, 
            string password)
        {
            var result = await this.userManager.CreateAsync(user, password);

            return result;
        }

        /// <summary>
        /// Method to update a given user (Asynchronous)
        /// </summary>
        /// <param name="user">IdentityUser</param>
        /// <returns>(void)</returns>
        public async Task UpdateUserAsync(IdentityUser user)
        {
            await this.userManager.UpdateAsync(user);
        }

        /// <summary>
        /// Method to add a user to a role (Asynchronous)
        /// </summary>
        /// <param name="user">IdentityUser</param>
        /// <param name="role">Role</param>
        /// <returns></returns>
        public async Task AddUserToRoleAsync(IdentityUser user, string role)
        {
            await this.userManager.AddToRoleAsync(user, role);
        }
    }
}
