namespace MarketVault.Tests.UnitTests
{
    using MarketVault.Data;
    using MarketVault.Tests.UnitTests.Mocks;
    using NUnit.Framework;

    /// <summary>
    /// Unit Test Base class
    /// </summary>
    public class UnitTestBase
    {
        /// <summary>
        /// ApplicationDbContext
        /// </summary>
        protected ApplicationDbContext context;

        /// <summary>
        /// Default constructor
        /// </summary>
        public UnitTestBase()
        {
            this.context = DatabaseMock.Mock;
        }

        /// <summary>
        /// Tear down method for db
        /// </summary>
        [TearDown]
        public void TearDownDb()
        {
            this.context.Dispose();
        }
    }
}
