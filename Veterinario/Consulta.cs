using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinario
{
    public class Consulta
    {
        private int _idConsulta;

        private int _idAnimal;

        public string? dataConsulta { get; set; }

        public string? horaConsulta { get; set; }

        public string? triagem { get; set; }

        private string? _crvm { get; set; }

        private string situacao = "Agendada";


        public Consulta(int ctIdconsulta, int ctIdAnimal, string ctData, string ctHora, string ctTriagem, string ctCrvm)
        {
            _idConsulta = ctIdconsulta;
            _idAnimal = ctIdAnimal;
            dataConsulta = ctData;
            horaConsulta = ctHora;
            triagem = ctTriagem;
            _crvm = ctCrvm;
        }
    }
}
