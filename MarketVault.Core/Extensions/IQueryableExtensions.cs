namespace MarketVault.Core.Extensions
{
    using MarketVault.Core.Models;
    using MarketVault.Infrastructure.Data.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Extension class for IQueryable
    /// </summary>
    public static class IQueryableExtensions
    {
        /// <summary>
        /// ProjectToProductServiceModel method
        /// </summary>
        /// <param name="queryble">IQueryable<Product></param>
        /// <returns>IQueryable<ProductServiceModel></returns>
        public static IQueryable<ProductServiceModel>
            ProjectToProductServiceModel(this IQueryable<Product> queryble)
        {
            return queryble
                .UseIncludeProductStatements()
                .Select(e => new ProductServiceModel()
                {
                    Id = e.Id,
                    ArticleNumber = e.ArticleNumber,
                    DateAdded = e.DateAdded,
                    CashRegisterName = e.CashRegisterName,
                    CodeForScales = e.CodeForScales,
                    DateModified = e.DateModified,
                    Description = e.Description,
                    ItemGroup = e.ItemGroup,
                    ItemGroupId = e.ItemGroupId,
                    Measure = e.ProductsMeasures.First().Measure,
                    MeasureId = e.ProductsMeasures.First().MeasureId,
                    Barcodes = e.Barcodes.ToList(),
                    Name = e.Name,
                    NomenclatureNumber = e.NomenclatureNumber,
                    PurchasePrice = e.PurchasePrice,
                    Quantity = e.Quantity,
                    SalePrice = e.SalePrice,
                });
        }

        /// <summary>
        /// UseIncludeProductStatements method
        /// </summary>
        /// <param name="queryble">IQueryable<Product></param>
        /// <returns>IQueryable<Product></returns>
        public static IQueryable<Product>
            UseIncludeProductStatements(this IQueryable<Product> queryble)
        {
            return queryble
                .Include(p => p.ItemGroup)
                .Include(p => p.Barcodes)
                .Include(p => p.ProductsMeasures)
                .ThenInclude(pm => pm.Measure)
                .Where(p => p.IsActive)
                .AsNoTracking();
        }
    }
}
