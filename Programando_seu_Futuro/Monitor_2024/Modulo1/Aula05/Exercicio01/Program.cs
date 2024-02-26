using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 16)
        {
            Console.WriteLine("Você pode votar!");
        }
    }
}