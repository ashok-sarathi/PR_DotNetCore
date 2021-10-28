using DotNetCoreData;
using DotNetCoreEntity.Identity;
using DotNetCoreSqlServerJwtSample.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace DotNetCoreSqlServerJwtSample.Controllers.Identity
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IJwtHelper _jwtHelper;
        private readonly DotNetCoreDbContext _context;

        public UserController(IJwtHelper jwtHelper, DotNetCoreDbContext context)
        {
            _context = context ?? throw new Exception(nameof(context));
            _jwtHelper = jwtHelper ?? throw new Exception(nameof(jwtHelper));
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public ActionResult<string> Login([FromBody] User model)
        {
            var data = _context.Set<User>().FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
            if (data == null)
            {
                return Unauthorized();
            }
            return _jwtHelper.GetJwtToken(new List<Claim>() {
                new Claim(ClaimTypes.Name, data.FirstName + " " + data.LastName),
                new Claim(ClaimTypes.Email, data.Email),
            });
        }

    }
}
