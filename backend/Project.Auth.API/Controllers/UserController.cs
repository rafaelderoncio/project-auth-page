using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project.Auth.API.Properties;

[Route("api/[controller]")]
[ApiController, Authorize]
public class UserController : ControllerBase
{
    
}