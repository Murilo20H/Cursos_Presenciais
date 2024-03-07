using System;

class Program
{
    static void Main(string[] args)
    {
        const int NUMERO_JOGADORES = 5;
        double somatorioAltura = 0;
        double maiorAltura = 0;

        for (int contador = 1; contador <= NUMERO_JOGADORES; contador++)
        {
            Console.Write("\nDigite a altura do " + contador + "º jogador: ");
            double alturaJogador = double.Parse(Console.ReadLine());
            somatorioAltura += alturaJogador;
            if(contador == 1)
            {
                maiorAltura = alturaJogador;
            }
            else if (alturaJogador >= maiorAltura)
            {
                maiorAltura = alturaJogador;
            }
        }
        double mediaAlturas = somatorioAltura / NUMERO_JOGADORES;
        Console.Write("\nA maior altura é: " + maiorAltura);
        Console.Write("\nA média de alturas é: " + Math.Round(mediaAlturas, 2));
    }
}