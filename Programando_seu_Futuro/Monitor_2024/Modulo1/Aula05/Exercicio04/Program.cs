using System;

class Program
{
    static void Main(string[] args)
    {
        const double pesoGalo = 54;
        const double pesoPena = 57;
        const double pesoLeve = 60;

        Console.Write("Digite o peso do lutador: ");
        double pesoLutador = double.Parse(Console.ReadLine());
        if(pesoLutador <= pesoGalo)
        {
            Console.WriteLine("A categoria do lutador é: Galo");
        }
        else if(pesoLutador <= pesoPena)
        {
            Console.WriteLine("A categoria do lutador é: Pena");
        }
        else if(pesoLutador <= pesoLeve)
        {
            Console.WriteLine("A categoria do lutador é: Leve");
        }
        else
        {
            Console.WriteLine("O lutador não está apto a competir em nenhuma categoria!");
        }
    }
}