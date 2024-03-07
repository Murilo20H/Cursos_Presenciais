using System;

class Program
{
    static void Main(string[] args)
    {
        const int VALOR_MAXIMO = 10;
        Console.Write("Digite um número para uma tabuada: ");
        int tabuadaDesejada = int.Parse(Console.ReadLine());

        int contador = 1;

        while (contador <= VALOR_MAXIMO)
        {
            Console.WriteLine(tabuadaDesejada + " X " + contador + " = " + (tabuadaDesejada * contador));
            contador++;
        }
    }
}