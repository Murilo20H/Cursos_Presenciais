using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int quantidadePositivos = 0;
        int quantidadeZeros = 0;
        int quantidadeNegativos = 0;

        for(int contador = 0; contador < 10; contador++)
        {
            int numero = int.Parse(Console.ReadLine());

            if(numero > 0)
            {
                quantidadePositivos++;
            }
            else if(numero < 0)
            {
                quantidadeNegativos++;
            }
            else
            {
                quantidadeZeros++;
            }
        }
        Console.WriteLine("Numeros positivos: " + quantidadePositivos);
        Console.WriteLine("Numeros negativos: " + quantidadeNegativos);
        Console.WriteLine("Zero(s): " + quantidadeZeros);
    }
}