using System;

class Program 
{
    static void Main(string[] args) 
    {
        Console.Write("Você possui o convite: ");
        bool possuiConvite = bool.Parse(Console.ReadLine());

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Você está acompanhado de um maior de idade: ");
        bool estaAcompanhado = bool.Parse(Console.ReadLine());

        bool podeEntrarNaFesta = possuiConvite && (idade >= 18 || estaAcompanhado);
        Console.WriteLine("Você pode entrar na festa: " + podeEntrarNaFesta);
    }
}