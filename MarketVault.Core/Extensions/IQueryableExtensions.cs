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
        /// ProjectToOperationServiceModel method
        /// </summary>
        /// <param name="queryble">IQueryable<Operation></param>
        /// <returns>IQueryable<OperationServiceModel></returns>
        public static IQueryable<OperationServiceModel>
            ProjectToOperationServiceModel(this IQueryable<Operation> queryble)
        {
            return queryble
                .UseIncludeOperationStatements()
                .Select(o => new OperationServiceModel()
                {
                    TotalPurchasePriceWithoutVAT = o.TotalPurchasePriceWithoutVAT,
                    DateMade = o.DateMade,
                    CounterPartyId = o.CounterPartyId,
                    DocumentTypeId = o.DocumentTypeId,
                    CounterParty = o.CounterParty,
                    DocumentType = o.DocumentType,
                    ProductsCount = o.ProductsOperations.Count(),
                    Id = o.Id,
                    TotalPurchasePriceWithVAT = o.TotalPurchasePriceWithVAT,
                    TotalSalePriceWithoutVAT = o.TotalSalePriceWithoutVAT,
                    UserId = o.UserId,
                    TotalSalePriceWithVAT = o.TotalSalePriceWithVAT
                });
        }

        /// <summary>
        /// UseIncludeOperationStatements method
        /// </summary>
        /// <param name="queryble">IQueryable<Operation></param>
        /// <returns>IQueryable<Operation></returns>
        public static IQueryable<Operation>
            UseIncludeOperationStatements(this IQueryable<Operation> queryble)
        {
            return queryble
                .Include(o => o.CounterParty)
                .Include(o => o.DocumentType);
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

        /// <summary>
        /// ProjectToItemGroupServiceModel method
        /// </summary>
        /// <param name="queryble">IQueryable<ItemGroup></param>
        /// <returns>IQueryable<ItemGroupServiceModel></returns>
        public static IQueryable<ItemGroupServiceModel>
            ProjectToItemGroupServiceModel(this IQueryable<ItemGroup> queryble)
        {
            return queryble
                .UseIncludeItemGroupStatements()
                .Select(e => new ItemGroupServiceModel()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Products = e.Products.Select(p => new ProductServiceModel()
                    {
                        ArticleNumber = p.ArticleNumber,
                        Barcodes = p.Barcodes.ToList(),
                        DateAdded = p.DateAdded,
                        Description = p.Description,
                        DateModified = p.DateModified,
                        CashRegisterName = p.CashRegisterName,
                        CodeForScales = p.CodeForScales,
                        Id = p.Id,
                        ItemGroupId = p.ItemGroupId,
                        ItemGroup = p.ItemGroup,
                        Measure = p.ProductsMeasures.Any() ? p.ProductsMeasures.First().Measure : new Measure(),
                        MeasureId = p.ProductsMeasures.Any() ? p.ProductsMeasures.First().MeasureId : 0,
                        Name = p.Name,
                        NomenclatureNumber = p.NomenclatureNumber,
                        PurchasePrice = p.PurchasePrice,
                        Quantity = p.Quantity,
                        SalePrice = p.SalePrice
                    })
                });
        }

        /// <summary>
        /// UseIncludeItemGroupStatements method
        /// </summary>
        /// <param name="queryble">IQueryable<ItemGroup></param>
        /// <returns>IQueryable<ItemGroup></returns>
        public static IQueryable<ItemGroup>
            UseIncludeItemGroupStatements(this IQueryable<ItemGroup> queryble)
        {
            return queryble
                .Include(ig => ig.Products)
                .Where(ig => ig.IsActive);
        }

        /// <summary>
        /// ProjectToAddressServiceModel method
        /// </summary>
        /// <param name="queryble">IQueryable<ItemGroup></param>
        /// <returns>IQueryable<ItemGroupServiceModel></returns>
        public static IQueryable<AddressServiceModel>
            ProjectToAddressServiceModel(this IQueryable<Address> queryble)
        {
            return queryble
                .UseIncludeAddressStatements()
                .Select(e => new AddressServiceModel()
                {
                    Id = e.Id,
                    StreetName = e.StreetName,
                    StreetNumber = e.StreetNumber,
                    TownName = e.TownName
                });
        }

        /// <summary>
        /// UseIncludeAddressStatements method
        /// </summary>
        /// <param name="queryble">IQueryable<Address></param>
        /// <returns>IQueryable<Address></returns>
        public static IQueryable<Address>
            UseIncludeAddressStatements(this IQueryable<Address> queryble)
        {
            return queryble
                .Where(a => a.IsActive);
        }
    }
}
