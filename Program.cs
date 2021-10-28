using System;

namespace VideoLibrary
{
    class Program
    {
        static SeriesRepository repository = new SeriesRepository();
        static void Main(string[] args)
        {
            string userOption = CallMenu();

            while (userOption != "0")
            {
                switch (userOption)
                {
                    case "1":
                        repository.List();
                        break;
                    case "2":
                        // TODO: Method to add Serie to repository
                        break;
                    case "3":
                        // TODO: Method to update Serie in repository
                        break;
                    case "4":
                        // TODO: Method to delete Serie to repository
                        break;
                    case "5":
                        // TODO: Method to view Serie info by ID
                        break;
                    case "0":
                        // Leaves
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                userOption = CallMenu();
            }

            Console.WriteLine("Até logo!");
        
        }

        private static string CallMenu()
        {
           Console.Clear();
           Console.WriteLine("Bem vindo ao <<< FakeFlix >>>!");
           Console.WriteLine("[1] - Listar séries");
           Console.WriteLine("[2] - Cadastrar nova série");
           Console.WriteLine("[3] - Atualizar série");
           Console.WriteLine("[4] - Excluir série");
           Console.WriteLine("[5] - Visualizar série");
           Console.WriteLine("[0] - Sair");
           Console.WriteLine("Escolha uma opção: ");
           Console.Write("> ");
           string option = Console.ReadLine();
           return option;
        }
    }
}
