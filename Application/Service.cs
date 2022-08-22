using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

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

            if (!File.Exists(firstPath) || !File.Exists(secondPath))
                return "Arquivos não encontrados";

            var firstStream = File.OpenRead(firstPath);
            string firstExtension = Path.GetExtension(firstStream.Name);

            var secondStream = File.OpenRead(secondPath);
            string secondExtension = Path.GetExtension(secondStream.Name);

            if (firstExtension != ".txt" || secondExtension != ".txt")
                return "Os arquivos não são do tipo texto";
            try
            {
                var firstContent = System.IO.File.ReadLines(firstPath);
                var secondContent = System.IO.File.ReadLines(secondPath);

                var firstContentLines = firstContent.Count();
                var secondContentLines = secondContent.Count();

                var diferences = new StringBuilder();
                int count = 0;
                while (count < firstContentLines || count < secondContentLines)
                {
                    string firstLine = string.Empty;
                    string secondLine = string.Empty;

                    if (count < firstContentLines)
                        firstLine = firstContent.ElementAt(count);

                    if (count < secondContentLines)
                        secondLine = secondContent.ElementAt(count);

                    if (!firstLine.Equals(secondLine))
                        diferences.AppendLine($"{count + 1} | {firstLine} --- {secondLine}");

                    count++;
                }

                return diferences.ToString();
            }
            catch
            {
                return "Erro ao comparar arquivos";
            }
        }
    }
}