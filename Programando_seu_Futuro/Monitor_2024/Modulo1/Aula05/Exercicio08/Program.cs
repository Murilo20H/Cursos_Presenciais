using System;

class Program
{
    static void Main(string[] args)
    {
        const double valorBoleto = 100;
        string statusBoleto = Console.ReadLine();
        // se boleto != vencido o valor sera o valor do boleto, senao sera o valor do boleto mais a multa
        double valorFinal = (statusBoleto != "vencido") ? valorBoleto : valorBoleto + (valorBoleto * 0.15);
        Console.WriteLine(valorFinal);
    }
}