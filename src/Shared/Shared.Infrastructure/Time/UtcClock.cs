using System;
using Shared.Abstractions.Time;

namespace Inflow.Shared.Infrastructure.Time;

public class UtcClock : IClock
{
    public DateTime CurrentDate() => DateTime.UtcNow;
}