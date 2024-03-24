namespace MarketVault.Core.Exceptions
{
    /// <summary>
    /// Custom exception class for no user found exception
    /// </summary>
    public class UserNotFoundException : Exception
    {
        /// <summary>
        /// Default constructor with default message
        /// </summary>
        public UserNotFoundException()
            : base("User not found!")
        {
        }

        /// <summary>
        /// Constructor with message
        /// </summary>
        /// <param name="message">Message</param>
        public UserNotFoundException(string message)
            : base(message)
        {
        }
    }
}
