﻿namespace MarketVault.Core.Services.Impementations
{
    using MarketVault.Core.Models;
    using MarketVault.Core.Services.Interfaces;
    using System.Threading.Tasks;

    /// <summary>
    /// Statistic Service class
    /// </summary>
    public class StatisticService : IStatisticService
    {
        /// <summary>
        /// Address service
        /// </summary>
        private readonly IAddressService addressService;

        /// <summary>
        /// Bank service
        /// </summary>
        private readonly IBankService bankService;

        /// <summary>
        /// Firm service
        /// </summary>
        private readonly IFirmService firmService;

        /// <summary>
        /// Item group service
        /// </summary>
        private readonly IItemGroupService itemGroupService;

        /// <summary>
        /// Product service
        /// </summary>
        private readonly IProductService productService;

        /// <summary>
        /// Counter party service
        /// </summary>
        private readonly ICounterPartyService counterPartyService;

        /// <summary>
        /// User service
        /// </summary>
        private readonly IUserService userService;

        /// <summary>
        /// Default constructor, injection of services
        /// </summary>
        /// <param name="addressService">IAddressService</param>
        /// <param name="bankService">IBankService</param>
        /// <param name="firmService">IFirmService</param>
        /// <param name="itemGroupService">IItemGroupService</param>
        /// <param name="productService">IProductService</param>
        /// <param name="userService">IUserService</param>
        /// <param name="counterPartyService">ICounterPartyService</param>
        public StatisticService(
            IAddressService addressService, 
            IBankService bankService, 
            IFirmService firmService, 
            IItemGroupService itemGroupService, 
            IProductService productService, 
            IUserService userService,
            ICounterPartyService counterPartyService)
        {
            this.addressService = addressService;
            this.bankService = bankService;
            this.firmService = firmService;
            this.itemGroupService = itemGroupService;
            this.productService = productService;
            this.userService = userService;
            this.counterPartyService = counterPartyService;
        }

        /// <summary>
        /// Asynchronous method for getting the statistic service model
        /// </summary>
        /// <returns>Task<StatisticServiceModel></returns>
        public async Task<StatisticServiceModel> GetStatisticServiceModelAsync()
        {
            return new StatisticServiceModel()
            {
                TotalAddresses = await addressService.GetCountAsync(),
                TotalBanks = await bankService.GetCountAsync(),
                TotalFirms = await firmService.GetCountAsync(),
                TotalItemGroups = await itemGroupService.GetCountAsync(),
                TotalProducts = await productService.GetCountAsync(),
                TotalUsers = await userService.GetUsersCountAsync(),
                TotalCounterParties = await counterPartyService.GetCountAsync()
            };
        }
    }
}
