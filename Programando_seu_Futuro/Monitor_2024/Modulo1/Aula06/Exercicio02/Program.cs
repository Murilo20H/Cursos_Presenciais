using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        while (numero <= 10)
        {
            Console.WriteLine("O número é: " + numero);
            numero++;
        }

        Console.WriteLine("Saiu do laço");
    }
}