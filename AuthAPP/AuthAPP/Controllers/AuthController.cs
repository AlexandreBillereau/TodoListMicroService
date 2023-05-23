using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using AuthAPP.Data;
using AuthAPP.Models;
using AuthAPP.utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace AuthAPP.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private static AuthContext _db;
   
    
    public AuthController(AuthContext db)
    {
        _db = db;
    }

    [HttpPost(Name = "./")]
    public async Task<string> auth(User credential)
    {
        var sha256 = UtilsSHA256.ComputeSha256Hash(credential.Pwd);
        var row= _db.User.FirstOrDefaultAsync(field => field.Name == credential.Name);

        if (row.Result.Pwd != sha256) { return "error"; }

        TokenData tokenDataData = new TokenData(new []
            {
                new Claim("name", credential.Name),
                new Claim( "role", "user")
            }
        );

        return AuthJWTUtils.gentokenJwt(tokenDataData);
    }
    
    [HttpPost("Create")]
    public async Task<User> create(User credential)
    {
        var generatedSha256 = UtilsSHA256.ComputeSha256Hash(credential.Pwd);
        var user = new User(credential.Name, generatedSha256);
        await _db.User.AddAsync(user);
        await _db.SaveChangesAsync();
        return user;
    }
    
    
}