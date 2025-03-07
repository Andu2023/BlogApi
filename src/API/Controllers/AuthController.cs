using Application.Interface;
using Application.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthenticationService authenticationService) :BasApiController
    {
    [HttpPost("register")]
     public async Task<IResult> Register(RegisterRequest registerRequest)
{

 var response= await authenticationService.RegisterAsync(registerRequest);
    return  Results.Ok( response);
        }

    [HttpPost("login")]
 public async Task<IResult> Login(LoginRequest loginRequest)
 {
    return Results.Ok();
     }
    }
}
