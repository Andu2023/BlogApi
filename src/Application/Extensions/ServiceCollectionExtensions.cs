using System;
using Application.Interface;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions;

public static class ServiceCollectionExtensions
{
  public static IServiceCollection AddApplication(this IServiceCollection services)

{
  services.AddScoped<IAuthenticationService, AuthenticationService>();
  return services;
}
}
