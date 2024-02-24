using System;

class Program 
{
    static void Main(string[] args) 
    {
        Console.Write("Digite o cheat code: ");
        string cheatCode = Console.ReadLine();

        if (cheatCode == "codigo ultra secreto")
        {
            Console.WriteLine("Você desbloqueou uma área secreta!");
        }
    }
}