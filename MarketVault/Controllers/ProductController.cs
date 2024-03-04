namespace MarketVault.Controllers
{
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.Product;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class ProductController : Controller
    {
        private IProductService service = null!;

        public ProductController(IProductService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return RedirectToAction("All");
        }

        public async Task<IActionResult> All()
        {
            var serviceModels = await this.service
                .GetAllAsync();

            var viewModels = serviceModels
            .Select(sm => new ProductViewModel()
            {
                Barcodes = sm.Barcodes,
                DateAdded = sm.DateAdded,
                CashRegisterName = sm.CashRegisterName,
                DateModified = sm.DateModified,
                CodeForScales = sm.CodeForScales,
                ItemGroupName = sm.ItemGroupName,
                Measure = sm.Measure,
                Name = sm.Name,
                PurchasePrice = sm.PurchasePrice,
                Quantity = sm.Quantity,
                SalePrice = sm.SalePrice
            })
            .ToList();

            return View(viewModels);
        }
    }
}
