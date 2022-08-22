using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application
{
    public class Presentation
    {
        public static void Initial()
        {
            Console.Clear();
            Console.WriteLine
            (
                @"===================================================================" + "\r\n" +
                @"   _____                                                           " + "\r\n" +
                @"  / ____|                                                          " + "\r\n" +
                @" | |        ___    _ __ ___    _ __     __ _   _ __   _   _   ___  " + "\r\n" +
                @" | |       / _ \  |  _   _ \  |  _ \   / _  | |  __| | | | | / __| " + "\r\n" +
                @" | |____  | (_) | | | | | | | | |_) | | (_| | | |    | |_| | \__ \ " + "\r\n" +
                @"  \_____|  \___/  |_| |_| |_| |  __/   \__ _| |_|     \__ _| |___/ " + "\r\n" +
                @"                              | |                                  " + "\r\n" +
                @"                              |_|                                  " + "\r\n" +
                @"===================================================================" + "\r\n" +
                @"                                                                   " + "\r\n" +
                @"-------------------------WELCOME TO COMPARUS-----------------------" + "\r\n"

            );
        }

        public static void Finish()
        {
            Console.Clear();
            Console.WriteLine
            (
                @"===================================================================" + "\r\n" +
                @"   _____                                                           " + "\r\n" +
                @"  / ____|                                                          " + "\r\n" +
                @" | |        ___    _ __ ___    _ __     __ _   _ __   _   _   ___  " + "\r\n" +
                @" | |       / _ \  |  _   _ \  |  _ \   / _  | |  __| | | | | / __| " + "\r\n" +
                @" | |____  | (_) | | | | | | | | |_) | | (_| | | |    | |_| | \__ \ " + "\r\n" +
                @"  \_____|  \___/  |_| |_| |_| |  __/   \__ _| |_|     \__ _| |___/ " + "\r\n" +
                @"                              | |                                  " + "\r\n" +
                @"                              |_|                                  " + "\r\n" +
                @"===================================================================" + "\r\n" +
                @"                                                                   " + "\r\n" +
                @"--------------------THANK YOU FOR USING COMPARUS-------------------" + "\r\n"
            );
            Thread.Sleep(3000);
            Console.Clear();
        }

        public static void Options()
        {
            Thread.Sleep(3000);
            // Console.Clear();
            Console.WriteLine
            (
                @"Selecione uma das opções abaixo:" + "\r\n" +
                @"                                " + "\r\n" +
                @"1 - Comparar arquivos de texto  " + "\r\n" +
                @"2 - Comparar arquivos JSON      " + "\r\n" +
                @"0 - Sair                        " + "\r\n"
            );
        }

        public static string FilePath()
        {
            Console.Clear();
            Console.WriteLine("Informe o caminho absoluto do primeiro arquivo:");
            string firstPath = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Informe o caminho absoluto do segundo arquivo:");
            string secondPath = Console.ReadLine();

            return firstPath + ";" + secondPath;
        }
    }
}

