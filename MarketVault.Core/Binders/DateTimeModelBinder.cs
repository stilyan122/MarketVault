namespace MarketVault.Core.Binders
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using System.Globalization;
    using System.Threading.Tasks;

    /// <summary>
    /// Custom Date Time Model Binder
    /// </summary>
    public class DateTimeModelBinder : IModelBinder
    {
        /// <summary>
        /// Bind model method (async)
        /// </summary>
        /// <param name="bindingContext">ModelBindingContext</param>
        /// <returns>(void)</returns>
        /// <exception cref="ArgumentException">Exception to throw when needed</exception>
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
