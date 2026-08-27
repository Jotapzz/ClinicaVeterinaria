using System;
using System.Collections.Generic;
using System.Text;

namespace Veterinario
{
    public class Tutor : Pessoa
    {
        private string? cpf { get; set; }
        List<Animal> animais;

  

        public void CadastrarTutor()
        {
            do
            {
                Console.Write("Digite o nome do Tutor: ");
                nomePessoa = Console.ReadLine()!;

                if (string.IsNullOrEmpty(nomePessoa) || nomePessoa.Length < 4)
                {
                    Console.Clear();
                    Console.WriteLine("Nome inválido, O nome precisa ter mais de 4 caractere");

                }

            } while (string.IsNullOrEmpty(nomePessoa) || nomePessoa.Length < 4);


            do
            {
                Console.Write("Digite o cpf do Tutor: ");
                cpf = Console.ReadLine()!;

                if (string.IsNullOrEmpty(cpf) || cpf.Length < 11)
                {
                    Console.Clear();
                    Console.WriteLine("CPF inválido é necessario ter 11 números");
                }

            } while (string.IsNullOrEmpty(cpf) || cpf.Length < 11);

            do
            {
                Console.Write("Digite o telefone do Tutor: ");
                telefonePessoa = Console.ReadLine()!;

                if (string.IsNullOrEmpty(telefonePessoa) || telefonePessoa.Length < 11)
                {
                    Console.Clear();
                    Console.WriteLine("telefone inválido, é necessario ter 11 Digitos com DDD");
                }

            } while (string.IsNullOrEmpty(telefonePessoa) || telefonePessoa.Length < 11);

            do
            {
                Console.Write("Digite o E-mail do Tutor: ");
                email = Console.ReadLine()!;

                if (string.IsNullOrEmpty(email) || email.Length < 11)
                {
                    Console.Clear();
                    Console.WriteLine("E-mail inválido, Digite um e-mail com 11 caracteres");
                }

            } while (string.IsNullOrEmpty(email) || email.Length < 11);

        }

        public void ConsultarTutor(List<Tutor> tutores)
        {
            Console.WriteLine("============ LISTA DE TUTORES ============");
            foreach(Tutor tutor in tutores) 
            {
                Console.WriteLine($"Nome: {tutor.nomePessoa} | Telefone: {tutor.telefonePessoa} | CPF: {tutor.cpf}");
            }
        }
    }
}
