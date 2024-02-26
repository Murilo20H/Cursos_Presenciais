using System;

class Program
{
    static void Main(string[] args)
    {
        const double saldo = 200;
        Console.Write("Digite o valor do item que deseja comprar: ")
        double valorCompra = double.Parse(Console.ReadLine());
        if(valorCompra > saldo)
        {
            Console.WriteLine("Saldo insuficiente para realizar a compra!");
        }
        else
        {
            Console.WriteLine("Compra realizada com sucesso!");
        }
    }
}