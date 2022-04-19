using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace RestWithASPNet.Services
{
    public interface ITokenInterface
    {

        string GenerateAccessToken(IEnumerable<Claim> claims);

        string GenerateRefreshToken();

        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
