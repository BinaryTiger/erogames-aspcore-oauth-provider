using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;

namespace OAuth.Erogames
{
    /// <summary>
    /// Defines a set of options used by <see cref="ErogamesAuthenticationHandler"/>.
    /// </summary>
    public class ErogamesAuthenticationOptions : OAuthOptions
    {
        public ErogamesAuthenticationOptions()
        {
            ClaimsIssuer = ErogamesAuthenticationDefaults.Issuer;
            CallbackPath = ErogamesAuthenticationDefaults.CallbackPath;
            AuthorizationEndpoint = ErogamesAuthenticationDefaults.AuthorizationEndpoint;
            TokenEndpoint = ErogamesAuthenticationDefaults.TokenEndpoint;
            UserInformationEndpoint = ErogamesAuthenticationDefaults.UserInformationEndpoint;
            
            Scope.Add("identity");
            
            ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "username");
            ClaimActions.MapJsonKey(ClaimTypes.Email, "email");
            ClaimActions.MapJsonKey(ClaimTypes.Locality, "language");
        }
        
    }
}