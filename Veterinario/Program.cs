namespace Veterinario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tutor tutor = new Tutor();
            List<Tutor> listaTutor = new List<Tutor>();



            //Variável Veterinario
            string nomeVeterinario;
            string telefoneVeterinario;
            string emailVeterinario;
            string crvm;
            string especialidade;

            //Variável Animal

            Animal animal = new Animal();
            int idAnimal;
            string nomeAnimal;
            string tipoAnimal;
            string racaAnimal;
            string dataAnimal;
            string horaAnimal;
            string dataNascimentoAnimal;


            int idConsulta;


            int opcao = 0;


            do
            {
                

                Console.WriteLine("=================================================");
                Console.WriteLine("------------- Clinica Veterinaria -------------");
                Console.WriteLine("=================================================");
                Console.WriteLine("1 - Cadastrar Tutor");
                Console.WriteLine("2 - Cadastrar Animal");
                Console.WriteLine("3 - Consultar Tutor");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("-------------------------------------------------");
                opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1:
                        
                        Console.Clear();
                        tutor.CadastrarTutor();
                        listaTutor.Add(tutor);
                        break;

                    case 2:
                        Console.Clear();
                        animal.CadastrarAnimal();
                        break;                                  

                    case 3:
                        tutor.ConsultarTutor(listaTutor);
                        break;

                    case 0:
                        Console.WriteLine("Programa Finalizado! Até Mais");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Digite uma opção Válida!");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
