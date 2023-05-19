using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AuthAPP.Models;
using Microsoft.IdentityModel.Tokens;

namespace AuthAPP.utils;

public class AuthJWTUtils
{
    public static string gentokenJwt(BluePrintToken bluePrintToken)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(bluePrintToken.secretKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: bluePrintToken.issuer,
            audience: bluePrintToken.audience,
            claims: bluePrintToken.claims,
            expires: DateTime.UtcNow.AddMinutes(bluePrintToken.expiryMinutes),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}