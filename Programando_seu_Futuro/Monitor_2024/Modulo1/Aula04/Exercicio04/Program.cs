using System;

class Program 
{
    static void Main(string[] args) 
    {
        Console.Write("A lampada está ligada: ");
        bool estaLigada = bool.Parse(Console.ReadLine());
        estaLigada = !estaLigada;
        Console.WriteLine("A lampada está ligada: " + fazerAcao);
    }
}