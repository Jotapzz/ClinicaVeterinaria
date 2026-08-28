using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinario
{
    public class Veterinario : Pessoa
    {
        private string? _crvm { get; set; }

        public string? especialidade { get; set; }

        /* public Veterinario(string ctCrvm, string ctEspecialidade, string ctNomeVeterinario, string ctTelefone, string ctEmail) : base(ctNomeVeterinario, ctTelefone, ctEmail)
         {
             _crvm = ctCrvm;
             especialidade = ctEspecialidade;
             nomePessoa = ctNomeVeterinario;
             telefonePessoa = ctTelefone;
             email = ctEmail; a
         }
        */

    }
}
