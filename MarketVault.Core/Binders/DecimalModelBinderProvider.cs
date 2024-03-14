namespace MarketVault.Core.Binders
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

    /// <summary>
    /// Custom Decimal Model Binder Provider
    /// </summary>
    public class DecimalModelBinderProvider : IModelBinderProvider
    {
        /// <summary>
        /// Get Binder method
        /// </summary>
        /// <param name="context">ModelBinderProviderContext</param>
        /// <returns>IModelBinder (nullable)</returns>
        /// <exception cref="ArgumentNullException">Exception to throw when needed</exception>
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(decimal))
            {
                return new BinderTypeModelBinder(typeof(DecimalModelBinder));
            }
            return null;
        }
    }
}
