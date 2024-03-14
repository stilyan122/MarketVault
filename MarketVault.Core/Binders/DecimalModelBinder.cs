namespace MarketVault.Core.Binders
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    /// <summary>
    /// Custom Decimal Model Binder
    /// </summary>
    public class DecimalModelBinder : IModelBinder
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
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var valueProviderResult = bindingContext.ValueProvider
                .GetValue(bindingContext.ModelName);
            if (valueProviderResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            bindingContext.ModelState
                .SetModelValue(bindingContext.ModelName, 
                valueProviderResult);

            var valueAsString = valueProviderResult.FirstValue;

            if (string.IsNullOrEmpty(valueAsString))
            {
                return Task.CompletedTask;
            }

            if (!decimal.TryParse(valueAsString, out var decimalValue))
            {
                bindingContext.ModelState.TryAddModelError(
                    bindingContext.ModelName,
                    "Invalid decimal format.");

                return Task.CompletedTask;
            }

            bindingContext.Result = ModelBindingResult.Success(decimalValue);

            return Task.CompletedTask;
        }
    }
}
