using codesquare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using static codesquare.Models.User;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using codesquare.Context;
using Microsoft.EntityFrameworkCore;

namespace codesquare.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JWTTokenController : ControllerBase
    {
        public IConfiguration _configuration;
        public readonly CodeSquareContext _context;

        public JWTTokenController(IConfiguration configuration, CodeSquareContext context)
        {
            _context = context;
            _configuration = configuration;

        }
        [HttpPost]

        public async Task<IActionResult> Post(User user)
        {
            if (user != null && user.UserName != null && user.Password != null)
            {
                var userData = await GetUser(user.UserName, user.Password);
                var jwt = _configuration.GetSection("Jwt").Get<Jwt>();
                if (user != null)

                {
                    var claims = new[]
                    {
                    new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, DateTime.UtcNow.ToString()),
                    new Claim("Id", user.UserId.ToString()),
                    new Claim("UserName", user.UserName),
                    new Claim("Password", user.Password)

                                        };
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.key));
                    var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        jwt.Issuer,
                        jwt.Audience,
                        claims,
                        expires: DateTime.Now.AddMinutes(200),
                        signingCredentials: signIn

                        );
                    return Ok(new JwtSecurityTokenHandler().WriteToken(token));


                }
                else
                {
                    return BadRequest("invalid credentials");
                }

            }
            else
            {
                return BadRequest("invalid credentials");
            }


        }

        [HttpGet]


        public async Task<User> GetUser(String username, string password)
        { return await _context.Users.FirstOrDefaultAsync(u => u.UserName == username && u.Password == password); }

    }
}

