using System;

class Program
{
    static void Main(string[] args)
    {
        double somatorio = 0;
        double valorInserido = 0;

        do
        {
            somatorio += valorInserido;
            Console.Write("\nDigite o valor que deseja doar: ");
            valorInserido = double.Parse(Console.ReadLine());        
        } 
        while (valorInserido >= 0);
        Console.Write("\nO valor arrecadado foi: R$" + somatorio);

    }
}