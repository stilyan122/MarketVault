namespace MarketVault.Core.Extensions
{
    using Microsoft.AspNetCore.Builder;
    using React.AspNet;

    /// <summary>
    /// Web application extensions static class
    /// </summary>
    public static class WebApplicationExtensions
    {
        /// <summary>
        /// Use endpoints static method
        /// </summary>
        /// <param name="app">WebApplication</param>
        public static void UseEndPoints(this WebApplication app)
        {
            app.UseEndpoints(endpoints =>
            {
                /* Address */

                endpoints.MapControllerRoute(
                   name: "Address Edit",
                   pattern: "/Address/Edit/{id}/{details}",
                   defaults: new
                   {
                       Controller = "Address",
                       Action = "Edit"
                   });

                endpoints.MapControllerRoute(
                    name: "Address Delete",
                    pattern: "/Address/Delete/{id}/{details}",
                    defaults: new
                    {
                        Controller = "Address",
                        Action = "Delete"
                    });

                /* Bank */

                endpoints.MapControllerRoute(
                    name: "Bank Details",
                    pattern: "/Bank/Details/{id}/{details}",
                    defaults: new
                    {
                        Controller = "Bank",
                        Action = "Details"
                    });

                endpoints.MapControllerRoute(
                    name: "Bank Edit",
                    pattern: "/Bank/Edit/{id}/{details}",
                    defaults: new
                    {
                        Controller = "Bank",
                        Action = "Edit"
                    });

                endpoints.MapControllerRoute(
                    name: "Bank Delete",
                    pattern: "/Bank/Delete/{id}/{details}",
                    defaults: new
                    {
                        Controller = "Bank",
                        Action = "Delete"
                    });

                /* Counter Party */

                endpoints.MapControllerRoute(
                   name: "Counter Party Details",
                   pattern: "/CounterParty/Details/{id}/{details}",
                   defaults: new
                   {
                       Controller = "CounterParty",
                       Action = "Details"
                   });

                endpoints.MapControllerRoute(
                    name: "Counter Party Edit",
                    pattern: "/CounterParty/Edit/{id}/{details}",
                    defaults: new
                    {
                        Controller = "CounterParty",
                        Action = "Edit"
                    });

                endpoints.MapControllerRoute(
                    name: "Counter Party Delete",
                    pattern: "/CounterParty/Delete/{id}/{details}",
                    defaults: new
                    {
                        Controller = "CounterParty",
                        Action = "Delete"
                    });

                /* Firm */

                endpoints.MapControllerRoute(
                   name: "Firm Details",
                   pattern: "/Firm/Details/{id}/{details}",
                   defaults: new
                   {
                       Controller = "Firm",
                       Action = "Details"
                   });

                endpoints.MapControllerRoute(
                   name: "Firm Edit",
                   pattern: "/Firm/Edit/{id}/{details}",
                   defaults: new
                   {
                       Controller = "Firm",
                       Action = "Edit"
                   });

                endpoints.MapControllerRoute(
                    name: "Firm Delete",
                    pattern: "/Firm/Delete/{id}/{details}",
                    defaults: new
                    {
                        Controller = "Firm",
                        Action = "Delete"
                    });

                /* Product */

                endpoints.MapControllerRoute(
                   name: "Product Details",
                   pattern: "/Product/Details/{id}/{details}",
                   defaults: new
                   {
                       Controller = "Product",
                       Action = "Details"
                   });

                endpoints.MapControllerRoute(
                  name: "Product Edit",
                  pattern: "/Product/Edit/{id}/{details}",
                  defaults: new
                  {
                      Controller = "Product",
                      Action = "Edit"
                  });

                endpoints.MapControllerRoute(
                    name: "Product Delete",
                    pattern: "/Product/Delete/{id}/{details}",
                    defaults: new
                    {
                        Controller = "Product",
                        Action = "Delete"
                    });

                /* Item Group */

                endpoints.MapControllerRoute(
                   name: "Item Group Edit",
                   pattern: "/ItemGroup/Edit/{id}/{details}",
                   defaults: new
                   {
                       Controller = "ItemGroup",
                       Action = "Edit"
                   });

                endpoints.MapControllerRoute(
                    name: "Item Group Delete",
                    pattern: "/ItemGroup/Delete/{id}/{details}",
                    defaults: new
                    {
                        Controller = "ItemGroup",
                        Action = "Delete"
                    });

                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapDefaultControllerRoute();

                endpoints.MapRazorPages();
            });
        }

        /// <summary>
        /// Use react components static method
        /// </summary>
        /// <param name="app">WebApplication</param>
        public static void UseReactComponents(this WebApplication app)
        {
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
        }
    }
}
