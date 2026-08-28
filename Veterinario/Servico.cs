using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinario
{
    public class Servico
    {
        private float _valor { get; set; }
        public string? nome { get; set; }

        public Servico(float ctValor, string nome)
        {
            _valor = ctValor;
            this.nome = nome;
        }
    }
}
