using System;

namespace Application.Common.Results;
public sealed record Error(string code, string message)
{
  internal static Error None =>new("None",string.Empty);
}