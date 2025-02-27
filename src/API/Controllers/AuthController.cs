using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController :BasApiController
    {
        [HttpPost("register")]
public async Task<IResult>  Register(RegisterRequest registerRequest){



            return Results.Ok();
        }
        
    
    [HttpPost("login")]
public async Task<IResult> Login(LoginRequest loginRequest)

{
    
            return Results.Ok();
        }
        
    }
}
