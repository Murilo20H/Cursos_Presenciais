using System;

public class Program
{
    public static void Main(string[] args)
    {
        int somatorio = 0;
        for (int contador = 0; contador <= 100; contador++)
        {
            int numero = int.Parse(Console.ReadLine());
            if (numero < 0)
            {
                break;
            }
            somatorio += numero;
        }
        Console.Write("O somatorio eh: " + somatorio);
    }
}