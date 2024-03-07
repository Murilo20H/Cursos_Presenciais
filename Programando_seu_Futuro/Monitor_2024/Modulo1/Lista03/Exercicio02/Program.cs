using System;

class Program
{
    static void Main(string[] args)
    {
        double precoItem = 0;
        double precoTotal = 0;
        int contador = 1;
        
        Console.Write("Quantos itens você comprou: ");
        int quantidadeItens = int.Parse(Console.ReadLine());

        while (contador <= quantidadeItens)
        {
            Console.Write("Digite o preço do item: ");
            precoItem = double.Parse(Console.ReadLine());
            precoTotal += precoItem;
            contador++;
        }
        
        if (precoTotal < 150)
        {
            Console.Write("\nA compra nao possui frete gratis");
        }
        else
        {
            Console.Write("\nParabens! Voce ganhou frete gratis em sua compra de valor " + Math.Round(precoTotal, 2));
        }
    }
}