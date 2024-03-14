namespace MarketVault.Core.Binders
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

    /// <summary>
    /// Custom Date Time Model Binder Provider
    /// </summary>
    public class DateTimeModelBinderProvider : IModelBinderProvider
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
            if (context.Metadata.ModelType == typeof(DateTime))
            {
                return new BinderTypeModelBinder(typeof(DateTimeModelBinder));
            }
            return null;
        }
    }
}
