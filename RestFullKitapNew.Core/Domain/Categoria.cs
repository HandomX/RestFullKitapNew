﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RestFullKitapNew.Core.Domain
{

    public class Categoria
    {
        
        public int ID { get; private set; }
        public string Nome { get; private set; }

        [JsonIgnore]
        public virtual ICollection<Livro> Livros { get; private set; }

        private Categoria()
        {

        }

        public static Categoria Criar(int id, string nome)
        {
            var categoria = new Categoria()
            {
                ID = id,
                Nome = nome
            };

            return categoria;
        }
    }
}
