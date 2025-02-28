using System;
using Application.Models.Request;

namespace Application.Interface;

public interface IAuth
{
  Task<string>RegisterAsync( RegisterRequest registerRequest);
  Task<string> LoginAsync(LoginRequest loginRequest);

}
