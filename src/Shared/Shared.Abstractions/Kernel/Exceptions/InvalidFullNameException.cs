using Shared.Abstractions.Exceptions;

namespace Shared.Abstractions.Kernel.Exceptions;

public class InvalidFullNameException : CustomException
{
    public string FullName { get; }

    public InvalidFullNameException(string fullName) : base($"Full name: '{fullName}' is invalid.")
    {
        FullName = fullName;
    }
}