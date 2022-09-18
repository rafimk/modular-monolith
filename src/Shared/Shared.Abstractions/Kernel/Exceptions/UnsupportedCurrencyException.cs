using Shared.Abstractions.Exceptions;

namespace Shared.Abstractions.Kernel.Exceptions;

public class UnsupportedCurrencyException : CustomException
{
    public string Currency { get; }

    public UnsupportedCurrencyException(string currency) : base($"Currency: '{currency}' is unsupported.")
    {
        Currency = currency;
    }
}