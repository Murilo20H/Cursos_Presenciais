using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite o preço do óculos: ");
        double preco = double.Parse(Console.ReadLine());

        preco -= idade;
        Console.WriteLine("O preço final é: " + preco);
    }
}