using System;

class Program
{
    static void Main(string[] args)
    {
        int somatorio = 0;
        int valorInserido = 0;

        do
        {
            Console.Write("\nDigite o valor que deseja doar: ");
            valorInserido = int.Parse(Console.ReadLine());        
            if (valorInserido % 2 == 1)
            {
                somatorio += valorInserido;
            }
        } 
        while (somatorio <= 50);
        Console.Write("\nO valor arrecadado foi: R$" + somatorio);

    }
}