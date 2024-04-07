namespace MarketVault.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Base controller class (Authorized)
    /// </summary>
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
