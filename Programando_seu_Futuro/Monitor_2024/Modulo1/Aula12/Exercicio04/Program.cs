using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int PESSOAS = 4;
            const int DADOS = 3;
            string[,] pessoas = new string[PESSOAS, DADOS];
            for (int pessoa = 0; pessoa < PESSOAS; pessoa++)
            {
                for (int dados = 0; dados < DADOS; dados++)
                {
                    pessoas[pessoa, dados] = Console.ReadLine();
                }
            }

            for (int pessoa = PESSOAS - 1; pessoa >= 0; pessoa--)
            {
                for (int dados = 0; dados < DADOS; dados++)
                {
                    Console.WriteLine(pessoas[pessoa, dados]);
                }
            }
        }
    }
}