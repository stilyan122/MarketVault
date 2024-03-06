namespace MarketVault
{
    using MarketVault.Core;
    using Microsoft.AspNetCore.StaticFiles;
    using Microsoft.Extensions.FileProviders;
    using Microsoft.AspNetCore.Http;
    using JavaScriptEngineSwitcher.V8;
    using JavaScriptEngineSwitcher.Extensions.MsDependencyInjection;
    using React.AspNet;

    /// <summary>
    /// Start point of the app
    /// </summary>
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Setting up services
            builder.Services.AddDbServices(builder.Configuration);
            builder.Services.AddIdentityServices();
            builder.Services.AddCoreServices();

            // Services, from google / chatgpt

            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  policy =>
                                  {
                                      policy.WithOrigins("http://example.com",
                                                          "http://www.contoso.com");
                                  });
            });

            builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            builder.Services.AddReact();

            // Make sure a JS engine is registered, or you will get an error!
            builder.Services.AddJsEngineSwitcher(
                options => options.DefaultEngineName = V8JsEngine.EngineName)
              .AddV8();

            // MVC Add Controllers with Views

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

            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseReact(config =>
            {
                //config
                //.AddScript("~/js/MyComponent.jsx");
            });

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