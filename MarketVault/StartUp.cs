namespace MarketVault
{
    using MarketVault.Core;
    using MarketVault.Core.Extensions;

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
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error/500");
                app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseReactComponents();

            app.UseStaticFiles();

            app.UseResponseCompression();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndPoints();

            app.Run();
        }
    }
}