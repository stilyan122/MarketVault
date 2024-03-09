using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketVault.Core.Services.Interfaces
{
    using MarketVault.Core.Models;

    /// <summary>
    /// Interface responsible for item group service
    /// </summary>
    public interface IProductMeasureService
    {
        /// <summary>
        /// Asynchronous method for adding a productMeasure entity
        /// </summary>
        /// <param name="productMeasure">ProductMeasure service model</param>
        /// <returns>(void)</returns>
        Task AddAsync(ProductMeasureServiceModel productMeasure);
    }
}
