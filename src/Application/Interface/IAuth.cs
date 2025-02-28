using System;
using Application.Models.Request;

namespace Application.Interface;

public interface IAuthenticationService
{
  Task<string>RegisterAsync( RegisterRequest registerRequest);
  Task<string> LoginAsync(LoginRequest loginRequest);

}
