﻿namespace MarketVault.Core.Services.Interfaces
{
    using Microsoft.AspNetCore.Identity;

    /// <summary>
    /// Interface responsible for user service
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Method to check if a given user by id is in role(s) (Asynchronous)
        /// </summary>
        /// <param name="roles">The roles to check</param>
        /// <param name="userId">User id to check</param>
        /// <returns>Task<bool></returns>
        public Task<bool> IsInRoleAsync(string[] roles, string userId);

        /// <summary>
        /// Method to check if a role exists (Asynchronous)
        /// </summary>
        /// <param name="role">Role name</param>
        /// <returns>Task<bool></returns>
        public Task<bool> RoleExistsAsync(string role);

        /// <summary>
        /// Method to create a given role (Asynchronous)
        /// </summary>
        /// <param name="role">IdentityRole</param>
        /// <returns>(void)</returns>
        public Task CreateRoleAsync(IdentityRole role);

        /// <summary>
        /// Method to update a given role (Asynchronous)
        /// </summary>
        /// <param name="role">IdentityRole</param>
        /// <returns>(void)</returns>
        public Task UpdateRoleAsync(IdentityRole role);

        /// <summary>
        /// Method to create a given user (Asynchronous)
        /// </summary>
        /// <param name="user">IdentityUser</param>
        /// <param name="password">User password</param>
        /// <returns>Task<IdentityResult></returns>
        public Task<IdentityResult> CreateUserAsync(IdentityUser user, string password);

        /// <summary>
        /// Method to update a given user (Asynchronous)
        /// </summary>
        /// <param name="user">IdentityUser</param>
        /// <returns>(void)</returns>
        public Task UpdateUserAsync(IdentityUser user);

        /// <summary>
        /// Method to add a user to a role (Asynchronous)
        /// </summary>
        /// <param name="user">IdentityUser</param>
        /// <param name="role">Role</param>
        /// <returns></returns>
        public Task AddUserToRoleAsync(IdentityUser user, string role);

        /// <summary>
        /// Method to find and return a user by email (Asynchronous)
        /// </summary>
        /// <param name="email">Email to search for</param>
        /// <returns>Task<IdentityUser></returns>
        public Task<IdentityUser> FindUserByEmailAsync(string email);
    }
}
