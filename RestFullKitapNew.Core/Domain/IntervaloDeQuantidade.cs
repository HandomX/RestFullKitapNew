using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServiceKitapNew.Dominio.DominioModel.Auxiliares
{
    public class IntervaloDeQuantidade
    {
        public int ValorDeInicio { get; private set; }
        public int ValorTotal { get; private set; }

        public IntervaloDeQuantidade(int valorDeInicio)
        {
            InicioInvalido(valorDeInicio);
            this.ValorDeInicio = valorDeInicio;
        }

        public IntervaloDeQuantidade(int valorDeInicio, int valorTotal)
        {
            InicioInvalido(valorDeInicio);
            this.ValorDeInicio = valorDeInicio;

            TotalInvalido(valorTotal);
            this.ValorTotal = valorTotal;
        }

        public void ResetarInicio(int novoInicio)
        {
            InicioInvalido(novoInicio);
            this.ValorDeInicio = novoInicio;
        }

        public void ResetarTotal(int novoTotal)
        {
            TotalInvalido(novoTotal);
            this.ValorTotal = novoTotal;
        }

        private void InicioInvalido(int valorDeInicio)
        {
            if (valorDeInicio <= 0) throw new Exception("Valor De Inicio Invalido");
        }

        private void TotalInvalido(int valorTotal)
        {
            if (valorTotal <= 0) throw new Exception("Valor Total Invalido");
        }
    }
}
