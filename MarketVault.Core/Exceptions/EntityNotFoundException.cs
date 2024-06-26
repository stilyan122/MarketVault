﻿namespace MarketVault.Core.Exceptions
{
    /// <summary>
    /// Custom exception class for no entity found exception
    /// </summary>
    public class EntityNotFoundException : Exception
    {
        /// <summary>
        /// Default constructor with default message
        /// </summary>
        public EntityNotFoundException()
            :base("Entity not found!")
        {
        }

        /// <summary>
        /// Constructor with message
        /// </summary>
        /// <param name="message">Message</param>
        public EntityNotFoundException(string message)
            :base(message)
        {  
        }
    }
}
