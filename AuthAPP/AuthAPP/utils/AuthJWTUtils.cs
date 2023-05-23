using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AuthAPP.Models;
using Microsoft.IdentityModel.Tokens;

namespace AuthAPP.utils;

public class AuthJWTUtils
{
    public static string gentokenJwt(TokenData tokenData)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenData.secretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: tokenData.issuer,
            audience: tokenData.audience,
            claims: tokenData.claims,
            expires: DateTime.UtcNow.AddMinutes(tokenData.expiryMinutes),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}