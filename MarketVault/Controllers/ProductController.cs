namespace MarketVault.Controllers
{
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Models.Product;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Product Controller (Authorized)
    /// </summary>
    [Authorize]
    public class ProductController : Controller
    {
        /// <summary>
        /// Product Service
        /// </summary>
        private readonly IProductService service = null!;

        /// <summary>
        /// Default constructor, injecting service (DI)
        /// </summary>
        /// <param name="service">IProductService</param>
        public ProductController(IProductService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Default Index action
        /// </summary>
        /// <returns>IActionResult</returns>
        public IActionResult Index()
        {
            return RedirectToAction("All");
        }

        /// <summary>
        /// Action for all products in app (Asynchronous)
        /// </summary>
        /// <returns>Task<IActionResult></returns>
        public async Task<IActionResult> All()
        {
            var serviceModels = await this.service
                .GetAllAsync();

            var viewModels = serviceModels
            .Select(sm => new ProductViewModel()
            {
                DateAdded = sm.DateAdded,
                CashRegisterName = sm.CashRegisterName,
                DateModified = sm.DateModified,
                CodeForScales = sm.CodeForScales,
                ItemGroupName = sm.ItemGroup.Name,
                Measure = sm.Measure.Name,
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
