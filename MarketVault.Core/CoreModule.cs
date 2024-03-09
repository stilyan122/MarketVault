namespace MarketVault.Core
{
    using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
    using JavaScriptEngineSwitcher.V8;
    using MarketVault.Core.Contracts;
    using MarketVault.Core.Implementations;
    using MarketVault.Core.Services.Impementations;
    using MarketVault.Core.Services.Interfaces;
    using MarketVault.Data;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using React.AspNet;

    /// <summary>
    /// Services modules
    /// </summary>
    public static class CoreModule
    {
        /// <summary>
        /// Adding custom services
        /// </summary>
        /// <param name="services">Service Collection</param>
        /// <returns></returns>
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICounterPartyService, CounterPartyService>();
            services.AddScoped<IItemGroupService, ItemGroupService>();
            services.AddScoped<IMeasureService, MeasureService>();
            services.AddScoped<IProductMeasureService, ProductMeasureService>();

            return services;
        }

        /// <summary>
        /// Adding services for DB Configuration
        /// </summary>
        /// <param name="services">Service Collection</param>
        /// <param name="configuration">Configuration object</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static IServiceCollection AddDbServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection") ?? 
                throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        /// <summary>
        /// Adding services for default Identity
        /// </summary>
        /// <param name="services">Service Collection</param>
        /// <returns></returns>
        public static IServiceCollection AddIdentityServices(this IServiceCollection services)
        {
            services.AddDefaultIdentity<IdentityUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }

        /// <summary>
        /// Adding services for usage of React
        /// </summary>
        /// <param name="services">Service Collection</param>
        /// <returns></returns>
        public static IServiceCollection AddReactServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddReact();

            services
                .AddJsEngineSwitcher(options =>
                options.DefaultEngineName = V8JsEngine.EngineName)
              .AddV8();

            return services;
        }
    }
}
