using System;

namespace Shared.Infrastructure.Security.Encryption;

[AttributeUsage(AttributeTargets.Property)]
public class HashedAttribute : Attribute
{
}