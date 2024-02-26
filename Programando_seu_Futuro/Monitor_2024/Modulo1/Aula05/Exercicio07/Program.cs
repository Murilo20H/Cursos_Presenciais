using System;

class Program
{
    static void Main(string[] args)
    {
        string nome = Console.ReadLine();
        // se nome = Mateus a idade sera 25, senao sera 22
        int idade = (nome == "Mateus") ? 25 : 22;
    }
}