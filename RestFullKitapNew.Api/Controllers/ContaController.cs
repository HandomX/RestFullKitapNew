using Microsoft.AspNet.Identity;
using RestFullKitapNew.Api.Identity;
using RestFullKitapNew.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace RestFullKitapNew.Api.Controllers
{
    [RoutePrefix("api/Conta")]
    public class ContaController : ApiController
    {
        private UsuarioAuthRepositorio repoUser;
        public ContaController()
        {
            repoUser = new UsuarioAuthRepositorio();
        }

        [AllowAnonymous]
        [Route("Cadastrar")]
        public async Task<IHttpActionResult> Register(UserCadastroModel userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            IdentityResult result = await repoUser.RegistrarUser(userModel);

            IHttpActionResult errorResult = GetErrorResult(result);

            if (errorResult != null)
            {
                return errorResult;
            }

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                repoUser.Dispose();
            }

            base.Dispose(disposing);
        }

        private IHttpActionResult GetErrorResult(IdentityResult result)
        {
            if (result == null)
            {
                return InternalServerError();
            }

            if (!result.Succeeded)
            {
                if (result.Errors != null)
                {
                    foreach (string error in result.Errors)
                    {
                        ModelState.AddModelError("", error);
                    }
                }

                if (ModelState.IsValid)
                {
                    // No ModelState errors are available to send, so just return an empty BadRequest.
                    return BadRequest();
                }

                return BadRequest(ModelState);
            }

            return null;
        }
    }
}
