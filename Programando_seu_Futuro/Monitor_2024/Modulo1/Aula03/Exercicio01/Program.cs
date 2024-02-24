using System;

class Program 
{
    static void Main(string[] args) 
    {
        const double precoDuzia = 14.99;

        Console.WriteLine("Digite a quantidade de laranjas: ");
        int quantidadeLaranjas = int.Parse(Console.ReadLine());

        int duzias = quantidadeLaranjas / 12;
        int resto = quantidadeLaranjas % 12;

        double precoFinal = (duzias * precoDuzia) + (precoDuzia * resto / 12);
        Console.WriteLine("O preço final é: " + precoFinal);
    }
}