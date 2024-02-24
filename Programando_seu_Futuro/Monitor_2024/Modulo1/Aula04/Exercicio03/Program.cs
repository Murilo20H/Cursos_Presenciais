using System;

class Program 
{
    static void Main(string[] args) 
    {
        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite a sua nacionalidade é xurupitense: ");
        bool xurupitense = bool.Parse(Console.ReadLine());
        
        Console.Write("Você é graduado em economia: ");
        bool graduadoEmEconomia = bool.Parse(Console.ReadLine());
        
        Console.Write("Você é graduado em gestão de políticas públicas: ");
        bool graduadoEmGestaoDePoliticasPublicas = bool.Parse(Console.ReadLine());

        bool podeSeCandidatar = (idade >= 30 && xurupitense) && (graduadoEmEconomia || graduadoEmGestaoDePoliticasPublicas);
        Console.WriteLine("Você pode se candidatar: " + podeSeCandidatar);
    }
}