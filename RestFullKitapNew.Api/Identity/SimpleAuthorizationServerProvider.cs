using Microsoft.Owin.Security.OAuth;
using RestFullKitapNew.Core.Domain;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RestFullKitapNew.Api.Identity
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            using (UsuarioAuthRepositorio _repo = new UsuarioAuthRepositorio())
            {
                Usuario user = await _repo.BuscarUser(context.UserName, context.Password);

                if (user == null)
                {
                    context.SetError("invalid_grant", "O nome de usuario ou senha está incorreto.");
                    return;
                }
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("sub", context.UserName));
            identity.AddClaim(new Claim("role", "user"));

            context.Validated(identity);

        }
    }
}