using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using RestFullKitapNew.Api.Models;
using RestFullKitapNew.Core.Domain;
using RestFullKitapNew.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestFullKitapNew.Api.Identity
{
    public class UsuarioAuthRepositorio : IDisposable
    {
        private KitapContext _ctx;

        private UserManager<Usuario> _userManager;

        public UsuarioAuthRepositorio()
        {
            _ctx = new KitapContext();
            _userManager = new UserManager<Usuario>(new UserStore<Usuario>(_ctx));
        }

        public async Task<IdentityResult> RegistrarUser(UserCadastroModel usuario)
        {
            Usuario user = Usuario.Criar(usuario.NomeDeUsuario, usuario.Email, usuario.NomeCompleto,
                                            usuario.ImageLink, usuario.Descricao, usuario.Telefone);            

            var result = await _userManager.CreateAsync(user, usuario.Senha);

            return result;
        }

        public async Task<Usuario> BuscarUser(string userName, string password)
        {
            Usuario user = await _userManager.FindAsync(userName, password);

            return user;
        }

        public async Task<Usuario> BuscarUserPorEmail(string email)
        {
            Usuario user = await _userManager.FindByEmailAsync(email);

            

            return user;
        }

        public async Task<UserInfomacaoModel> BuscarUserPorNome(string nome)
        {
            Usuario user = await _userManager.FindByNameAsync(nome);

            var usuarioInfo = new UserInfomacaoModel()
            {
                Id = user.Id,
                NomeCompleto = user.NomeCompleto,
                NomeDeUsuario = user.UserName,
                Email = user.Email,
                Telefone = user.PhoneNumber,
                Descricao = user.Descricao,
                ImageLink = user.ImageLink
            };

            return usuarioInfo;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}
