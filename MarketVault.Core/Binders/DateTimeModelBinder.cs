namespace MarketVault.Core.Binders
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using System.Globalization;
    using System.Threading.Tasks;

    public class DateTimeModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentException(nameof(bindingContext));
            }

            var providerResult = bindingContext.ValueProvider
                .GetValue(bindingContext.ModelName);

            if (providerResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            bindingContext.ModelState.SetModelValue(bindingContext.ModelName,
                providerResult);

            var valueAsString = providerResult.FirstValue;
            if (String.IsNullOrEmpty(valueAsString))
            {
                return Task.CompletedTask;
            }

            if (!DateTime.TryParse(valueAsString,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out var dateTime))
            {
                bindingContext.ModelState.TryAddModelError(
                    bindingContext.ModelName,
                    "Invalid DateTime format.");

                return Task.CompletedTask;
            }

            bindingContext.Result = ModelBindingResult.Success(dateTime);
            return Task.CompletedTask;
        }
    }
}
