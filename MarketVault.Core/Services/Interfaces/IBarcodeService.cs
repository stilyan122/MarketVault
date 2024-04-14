namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Infrastructure.Data.Models;

    /// <summary>
    /// Interface responsible for barcode service
    /// </summary>
    public interface IBarcodeService
    {
        /// <summary>
        /// Add barcode method (Asynchronous)
        /// </summary>
        /// <param name="barcode">Barcode to add</param>
        /// <returns>(void)</returns>
        public Task AddAsync(Barcode barcode);
    }
}
