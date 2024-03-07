using System;

class Program
{
    static void Main(string[] args)
    {
        double somatorio = 0;
        string resposta = "s";

        while (resposta == "s")
        {
            Console.Write("\nDigite o valor que deseja doar: ");
            double valorDigitado = double.Parse(Console.ReadLine());
            somatorio += valorDigitado;
            Console.Write("\nDeseja continuar?\n[s] - sim\n[n] - não\n");
            resposta = Console.ReadLine();
        }
        Console.Write("\nO valor total arrecadado foi: " + somatorio);
    }
}