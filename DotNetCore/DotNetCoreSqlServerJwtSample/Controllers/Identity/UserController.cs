using DotNetCoreService.Identity.Model;
using DotNetCoreService.Identity.Service;
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
        private readonly IUserService _userService;

        public UserController(IJwtHelper jwtHelper, IUserService userService)
        {
            _jwtHelper = jwtHelper ?? throw new Exception(nameof(jwtHelper));
            _userService = userService ?? throw new Exception(nameof(userService));
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public ActionResult<string> Login([FromBody] UserModel model)
        {
            //var data = _context.Set<User>().FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
            //if (data == null)
            //{
            //    return Unauthorized();
            //}
            //return _jwtHelper.GetJwtToken(new List<Claim>() {
            //    new Claim(ClaimTypes.Name, data.FirstName + " " + data.LastName),
            //    new Claim(ClaimTypes.Email, data.Email),
            //});
            _userService.GetUser(model);
            return "";
        }

    }
}
