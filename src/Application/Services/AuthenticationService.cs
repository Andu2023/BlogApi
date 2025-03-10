using System;
using System.ComponentModel;
using System.Linq.Expressions;
using Application.Common.Results;
using Application.Error;
using Application.Interface;
using Application.Models.Request;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public class AuthenticationService(IUserRepository userRepository, IUnitOfWork unitOfWork) : IAuthenticationService
{

    public Task<string> LoginAsync(LoginRequest loginRequest)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> RegisterAsync(RegisterRequest registerRequest)
    {
        
        if (registerRequest == null){
          return Result.Failure(AuthError.InvalidRegisterRequest);
        }
        // Check if the user already exists
    var existingUser = await userRepository.GetUserByEmailAsync(registerRequest.Email);
    if (existingUser != null)
    {
          return Result.Failure(AuthError.UserAlreadyExist); ;
    }
        var user= new User
        {
          Username = registerRequest.Username,
          Email=registerRequest.Email,
          Password=registerRequest.Password
        };

        await userRepository.AddAsync(user);
        await unitOfWork.CommitAsync();
        return Result.Success("sucsesfully register");

    }
}
