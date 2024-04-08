namespace MarketVault.Areas.Admin.Controllers
{
    using MarketVault.Controllers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using static MarketVault.Infrastructure
          .Constants.DataConstants.RoleConstants;

    /// <summary>
    /// Admin Base Controller (Authorized)
    /// </summary>
    [Area(AdminRole)]
    [Authorize(Roles = AdminRole)]
    public class AdminBaseController : BaseController
    {
        
    }
}
