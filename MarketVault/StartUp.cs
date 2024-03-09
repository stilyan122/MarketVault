namespace MarketVault
{
    using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
    using JavaScriptEngineSwitcher.V8;
    using MarketVault.Core;
    using Microsoft.AspNetCore.Http;
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
                .AddScript("~/js/marketvault/src/Components/CommentBox.jsx")
                .AddScript("~/js/marketvault/src/Components/ProductViewComponent.jsx");
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