using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinario
{
    public class Animal
    {
        //Atributos
        private int _idAnimal { get; }
        public string? nomeAnimal;
        public string? tipoAnimal;
        public string? racaAnimal;
        private string? _dataNascimentoAnimal;
        private string? _cpfTutor;

        

        //Funções
        public void CadastrarAnimal()
        {
            do
            {
                Console.Write("Digite o nome do Animal: ");
                nomeAnimal = Console.ReadLine()!;

                if (string.IsNullOrEmpty(nomeAnimal) || nomeAnimal.Length < 4)
                {
                    Console.Clear();
                    Console.WriteLine("Nome do Animal inválido, O nome precisa ter mais de 4 caractere");

                }

            } while (string.IsNullOrEmpty(nomeAnimal) || nomeAnimal.Length < 4);


            do
            {
                Console.Write("Digite o tipo do Animal: ");
                tipoAnimal = Console.ReadLine()!;

                if (string.IsNullOrEmpty(tipoAnimal) || tipoAnimal.Length < 4)
                {
                    Console.Clear();
                    Console.WriteLine("Tipo do Animal inválido, é necessario ter pelo menos 4 caractere");
                }

            } while (string.IsNullOrEmpty(tipoAnimal) || tipoAnimal.Length < 4);

            do
            {
                Console.Write("Digite a raça do Animal: ");
                racaAnimal = Console.ReadLine()!;

                if (string.IsNullOrEmpty(racaAnimal) || racaAnimal.Length < 8)
                {
                    Console.Clear();
                    Console.WriteLine("Raça do Animal Inválido,é necessario ter pelo menos 8 caractere");
                }

            } while (string.IsNullOrEmpty(racaAnimal) || racaAnimal.Length < 8);

        }

    }
}
