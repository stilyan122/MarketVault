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
                    Measure = e.ProductsMeasures.Any() ? e.ProductsMeasures.First().Measure : new Measure(),
                    MeasureId = e.ProductsMeasures.Any() ? e.ProductsMeasures.First().MeasureId : 0,
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
                .Include(p => p.ProductsOperations)
                .ThenInclude(po => po.Operation)
                .Include(p => p.ProductsMeasures)
                .ThenInclude(pm => pm.Measure)
                .Where(p => p.IsActive);
        }

        /// <summary>
        /// ProjectToCounterPartyServiceModel method
        /// </summary>
        /// <param name="queryble">IQueryable<CounterParty></param>
        /// <returns>IQueryable<CounterPartyServiceModel></returns>
        public static IQueryable<CounterPartyServiceModel>
            ProjectToCounterPartyServiceModel(this IQueryable<CounterParty> queryble)
        {
            return queryble
                .UseIncludeCounterPartyStatements()
                .Select(e => new CounterPartyServiceModel()
                {
                    Bank = e.Bank,
                    BankCode = e.BankCode,
                    ValueAddedTaxLawId = e.ValueAddedTaxLawId,
                    VATNumber = e.VATNumber,
                    BankIBAN = e.BankIBAN,
                    BankId = e.BankId,
                    Firm = e.Firm,
                    FirmId = e.FirmId,
                    Id = e.Id,
                    Name = e.Name
                });
        }

        /// <summary>
        /// UseIncludeCounterPartyStatements method
        /// </summary>
        /// <param name="queryble">IQueryable<CounterParty></param>
        /// <returns>IQueryable<CounterParty></returns>
        public static IQueryable<CounterParty>
            UseIncludeCounterPartyStatements(this IQueryable<CounterParty> queryble)
        {
            return queryble
                .Include(cp => cp.Bank)
                .ThenInclude(cp => cp.Address)
                .Include(cp => cp.Firm)
                .ThenInclude(cp => cp.Address)
                .Where(cp => cp.IsActive);
        }

        /// <summary>
        /// ProjectToFirmServiceModel method
        /// </summary>
        /// <param name="queryble">IQueryable<Firm></param>
        /// <returns>IQueryable<FirmServiceModel></returns>
        public static IQueryable<FirmServiceModel>
            ProjectToFirmServiceModel(this IQueryable<Firm> queryble)
        {
            return queryble
                .UseIncludeFirmStatements()
                .Select(e => new FirmServiceModel()
                {
                    Address = e.Address,
                    AddressId = e.AddressId,
                    Email = e.Email,
                    PhoneNumber = e.PhoneNumber,
                    Id = e.Id,
                    Name = e.Name,
                    ResponsiblePersonName = e.ResponsiblePersonName
                });
        }

        /// <summary>
        /// UseIncludeFirmStatements method
        /// </summary>
        /// <param name="queryble">IQueryable<Firm></param>
        /// <returns>IQueryable<Firm></returns>
        public static IQueryable<Firm>
            UseIncludeFirmStatements(this IQueryable<Firm> queryble)
        {
            return queryble
                .Include(f => f.Address)
                .Where(f => f.IsActive);
        }

        /// <summary>
        /// ProjectToBankServiceModel method
        /// </summary>
        /// <param name="queryble">IQueryable<Bank></param>
        /// <returns>IQueryable<BankServiceModel></returns>
        public static IQueryable<BankServiceModel>
            ProjectToBankServiceModel(this IQueryable<Bank> queryble)
        {
            return queryble
                .UseIncludeBankStatements()
                .Select(e => new BankServiceModel()
                {
                    Address = e.Address,
                    AddressId = e.AddressId,
                    Id = e.Id,
                    Name = e.Name
                });
        }

        /// <summary>
        /// UseIncludeBankStatements method
        /// </summary>
        /// <param name="queryble">IQueryable<Bank></param>
        /// <returns>IQueryable<Bank></returns>
        public static IQueryable<Bank>
            UseIncludeBankStatements(this IQueryable<Bank> queryble)
        {
            return queryble
                .Include(f => f.Address)
                .Where(f => f.IsActive);
        }
    }
}
