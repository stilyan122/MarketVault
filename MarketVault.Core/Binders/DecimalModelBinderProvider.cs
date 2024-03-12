namespace MarketVault.Core.Binders
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

    public class DecimalModelBinderProvider : IModelBinderProvider
    {
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
