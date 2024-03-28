namespace MarketVault.Tests.UnitTests.Mocks
{
    using MarketVault.Data;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Static class used for getting a mock with the Database
    /// </summary>
    public static class DatabaseMock
    {
        public static ApplicationDbContext Mock
        {
            get
            {
                var dbContextOptions = new
                    DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("MarketVaultDb" + DateTime.Now.Ticks)
                    .Options;

                return new ApplicationDbContext(dbContextOptions);
            }
        }
    }
}
