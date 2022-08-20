using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public class Service
    {
        public static void Menu()
        {
            Presentation.Options();
            string input = Console.ReadLine();

            int option = 0;
            try
            {
                option = Int32.Parse(input);
            }
            catch
            {
                Console.WriteLine("Escolha uma opção válida");
                Menu();
            }

            switch (option)
            {
                case 1:
                    string filePath = Presentation.FilePath();
                    Console.WriteLine(CompareTextFiles(filePath));
                    Menu();
                    break;
                case 2:
                    Console.WriteLine("Em desenvolvimento");
                    Menu();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    Menu();
                    break;
            }
        }

        private static string CompareTextFiles(string filePath)
        {
            var firstPath = filePath.Split(";")[0];
            var secondPath = filePath.Split(";")[1];

            if (firstPath.Split(".").Count() != 2 || secondPath.Split(".").Count() != 2)
                return "Os caminhos possuem caracteres inválidos";

            if (firstPath.Split(".")[1] != "txt" || secondPath.Split(".")[1] != "txt")
                return "Os arquivos não são do tipo texto";

            if (!System.IO.File.Exists(firstPath) || !System.IO.File.Exists(firstPath))
                return "Arquivos não encontrados";

            try
            {
                var firstContent = System.IO.File.ReadLines(firstPath);
                var secondContent = System.IO.File.ReadLines(secondPath);

                return "Arquivos comparados com sucesso";
            }
            catch
            {
                return "Erro ao comparar arquivos";
            }
        }
    }
}