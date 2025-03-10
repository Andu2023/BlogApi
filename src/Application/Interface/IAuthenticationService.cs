using System;
using Application.Common.Results;
using Application.Models.Request;

namespace Application.Interface;

public interface IAuth
{
  Task<Result>RegisterAsync( RegisterRequest registerRequest);
  Task<Result> LoginAsync(LoginRequest loginRequest);

}
