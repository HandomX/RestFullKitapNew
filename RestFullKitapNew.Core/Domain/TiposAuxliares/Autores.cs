using System;
using System.Collections.Generic;
using System.Text;

namespace RestFullKitapNew.Core.Domain.TiposAuxliares
{
    public class Autores
    {
        private List<string> _Autores;

        public Autores()
        {
            this._Autores = new List<string>();
        }

        public void AdicionarAutor(string nome)
        {
            if (ValorVazio(nome))
                throw new Exception("Nome De Autor Invalido");

            if (VerificarSeExite(nome))
                throw new Exception("Este Autor Já Consta Na Lista.");
                
            _Autores.Add(nome);
        }

        private bool VerificarSeExite(string nome)
        {
            return _Autores.Contains(nome);
        }

        private bool ValorVazio(string nome)
        {
            if (nome == null)
                return true;
            else if (nome.Equals(""))
                return true;

            return false;
        }

        public List<string> GetListaDeAutores()
        {
            return _Autores;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int cont = 1;
            foreach(var nome in _Autores)
            {
                if (cont != _Autores.Count)
                    sb.Append(nome + ", ");
                else
                    sb.Append(nome);
            }

            
            return sb.ToString();
        }
    }
}