namespace MarketVault
{
    using MarketVault.Core;
    using React.AspNet;

    /// <summary>
    /// Start point of the app
    /// </summary>
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbServices(builder.Configuration);
            builder.Services.AddIdentityServices();
            builder.Services.AddCoreServices();
            builder.Services.AddReactServices();
            builder.Services.AddBinderServices();
            
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseReact(config =>
            {
                config
                .AddScript("~/js/marketvault/src/Components/ProductViewComponent.jsx")
                .AddScript("~/js/marketvault/src/Components/CounterPartyViewComponent.jsx")
                .AddScript("~/js/marketvault/src/Components/FirmViewComponent.jsx")
                .AddScript("~/js/marketvault/src/Components/BankViewComponent.jsx")
                .AddScript("~/js/marketvault/src/Components/ItemGroupViewComponent.jsx")
                .AddScript("~/js/marketvault/src/Components/AddressViewComponent.jsx");
            });

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
    }
}