﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RestFullKitapNew.Core.Domain.TiposAuxliares
{
    public class ISBNValidador : ValidationAttribute
    {

        public string Isbn { get; private set; }

        public ISBNValidador()
        {
            ErrorMessage = "ISBN Invalido por favor forneça um valido.";
        }

        public override bool IsValid(object value)
        {
            ErrorMessage = "ISBN Invalido por favor forneça um valido.";
            var isbn = value as string;
            if(isbn != null)
            {
                this.Isbn = isbn;
                return (VerificarContemSomenteNumero() & VerificarTipoEhCalculaDigitoVerificadorDoISBN());
            }
                
            return true;
        }
        
        private bool VerificarContemSomenteNumero()
        {
            string regex = @"^\d{10}$|^\d{13}$";

            return Regex.IsMatch(this.Isbn, regex);
        }

        private bool VerificarTipoEhCalculaDigitoVerificadorDoISBN()
        {
            if (Isbn.Count() == 10)
                return this.CalcularDigitoVerificadorISBN10();

            else if (Isbn.Count() == 13)
                return this.CalcularDigitoVerificadorISBN13();

            return false;

        }

        private bool CalcularDigitoVerificadorISBN10()
        {

            int[] isbnNumerico = ConverteIsbnDeStringParaArrayDeInteiros();
            int totalDaSoma = 0, digitoVerificador;

            for (int peso = 1; peso <= 9; peso++)
            {
                totalDaSoma += (isbnNumerico[peso - 1] * peso);
            }

            digitoVerificador = totalDaSoma % 11;

            if (digitoVerificador == isbnNumerico[9])
                return true;

            return false;
        }

        private bool CalcularDigitoVerificadorISBN13()
        {
            int[] isbnNumerico = ConverteIsbnDeStringParaArrayDeInteiros();
            int totalDaSoma = 0, digitoVerificador;

            for (int posicao = 1; posicao <= 12; posicao++)
            {
                totalDaSoma += (posicao % 2 == 0) ? isbnNumerico[posicao - 1] * 3 : isbnNumerico[posicao - 1];
            }

            digitoVerificador = 10 - (totalDaSoma % 10);

            if (digitoVerificador == isbnNumerico[12])
                return true;

            return false;
        }

        private int[] ConverteIsbnDeStringParaArrayDeInteiros()
        {
            List<int> isbnNumerico = new List<int>();

            foreach (var valor in Isbn)
            {
                int numero = Convert.ToInt32(Char.GetNumericValue(valor));
                isbnNumerico.Add(numero);
            }
            return isbnNumerico.ToArray();
        }
    }
}