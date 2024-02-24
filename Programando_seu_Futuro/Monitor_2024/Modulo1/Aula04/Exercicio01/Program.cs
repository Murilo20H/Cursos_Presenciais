using System;

class Program 
{
    static void Main(string[] args) 
    {
        Console.Write("Digite o sexo: ");
        string sexo = Console.ReadLine();

        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());

        bool debutante = (idade == 15) && (sexo == "feminino");
        Console.WriteLine("Festa de debutante: " + debutante);
    }
}