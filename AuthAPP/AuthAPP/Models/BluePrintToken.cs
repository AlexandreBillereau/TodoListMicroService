using System.Security.Claims;

namespace AuthAPP.Models;

public class BluePrintToken
{
    public readonly string secretKey;
    public readonly string issuer;
    public readonly string audience;
    public readonly int expiryMinutes;
    public readonly Claim[] claims;
    
    public BluePrintToken(Claim[] claims)
    {
        secretKey = "t6w9z$C&F)J@NcQf";
        issuer = "AuthAPP";
        audience = "ServerTodoList";
        expiryMinutes = 60;
        this.claims = claims;
    }

    
}